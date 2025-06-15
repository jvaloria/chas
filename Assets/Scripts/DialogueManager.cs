using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using Ink.UnityIntegration;
using System;
using Unity.VisualScripting;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager _instance;
    private DialogueVariables _dialogueVariables;
    [Header("Globals Ink File")]

    [Header("DialogueUI")]
    [SerializeField] private GameObject _dialoguePanel;
    [SerializeField] private GameObject _continueIcon;
    [SerializeField] private TextMeshProUGUI _dialogueText;
    [SerializeField] private float _typingSpeed = 0.4f;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] _choices;
    [SerializeField] private TimedOptionSlider[] _sliders;
    [SerializeField] private TextMeshProUGUI[] _choicesText;

    private Story _currentStory;
    bool _dialogueIsPlaying;
    private string _line;

    private Coroutine _displayLineCoroutine;
    public bool canContinueToNextLine = false;

    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _dialogueIsPlaying = false;
        //_dialoguePanel.SetActive(false);

        //_choicesText = new TextMeshProUGUI[_choices.Length];
        int index = 0;
        foreach (GameObject choice in _choices)
        {
            _choices[index].gameObject.SetActive(false);
            index++;
        }
        _dialogueVariables = DialogueVariables.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_dialogueIsPlaying)
        {
            return;
        }
    }

    public void EnterDialogueMode (TextAsset inkJSON)
    {
        _currentStory = new Story(inkJSON.text);
        _dialogueIsPlaying = true;
        _dialoguePanel.SetActive(true);
        canContinueToNextLine = true;

        _dialogueVariables.StartListening(_currentStory);

        _currentStory.BindExternalFunction("LoadScreen", (int screenToLoad) =>
        {
            FindAnyObjectByType<SceneChanger>().LoadSceneByIndex(screenToLoad);
            //SceneManager.LoadScene(screenToLoad);
        });
        _currentStory.BindExternalFunction("LoadObject", (string imageToLoad) =>
        {
            ObjectManager.GetInstance().EnableObject(imageToLoad);
        });
        _currentStory.BindExternalFunction("RemoveObject", (string imageToRemove) =>
        {
            ObjectManager.GetInstance().DisableObject(imageToRemove);
        });
        _currentStory.BindExternalFunction("TimedOption", (int optionToTime, int timeForOption) =>
        {
            _sliders[optionToTime].EnableTimer(timeForOption);
        });
        _currentStory.BindExternalFunction("PlaySound", (string soundToPlay, float volume) =>
        {
            SoundManager.PlaySceneSFX(soundToPlay, volume);
        });


        ContinueStory();
    }

    private void ExitDialogueMode()
    {
        _currentStory.UnbindExternalFunction("LoadScreen");
        _currentStory.UnbindExternalFunction("LoadImage");
        _currentStory.UnbindExternalFunction("RemoveImage");
        _currentStory.UnbindExternalFunction("TimedOption");
        _currentStory.UnbindExternalFunction("PlaySound");
        _dialogueVariables.StopListening(_currentStory);
        _dialogueIsPlaying = false;
        _dialoguePanel.SetActive(false);
        _dialogueText.text = "";

    }


    public static DialogueManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameObject().AddComponent<DialogueManager>();
            DontDestroyOnLoad(_instance.gameObject);

        }
        return _instance;
    }

    public void ContinueStory()
    {
        if (_dialogueIsPlaying)
        {
            if (canContinueToNextLine)
            {
                if (_currentStory.canContinue)
                {
                    //set text for the dialogue line
                    //_dialogueText.text = currentStory.Continue();
                    if (_displayLineCoroutine != null)
                    {
                        StopCoroutine(_displayLineCoroutine);
                    }
                    _displayLineCoroutine = StartCoroutine(DisplayLine(_currentStory.Continue()));
                }
                else
                {
                    ExitDialogueMode();
                }
            }
            else
            {
                StopCoroutine(_displayLineCoroutine);
                _dialogueText.text = _line;
                _continueIcon.SetActive(true);
                DisplayChoices();
                canContinueToNextLine = true;
            }
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        _line = line;
        if (_dialogueText.text != line || line =="")
        {
            _dialogueText.text = "";
            _continueIcon.SetActive(false);
            HideChoices();

            canContinueToNextLine = false;
            bool isAddingRichTextTags = false;
            foreach (var letter in line.ToCharArray())
            {
                // if the player presses a button, skip the typing effect
                /*if (Input.GetButton("Fire1") || Input.GetButton("Submit") || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
                {
                    _dialogueText.text = line;
                    break;
                }*/

                // if the letter is a rich text tag, add it to the text without waiting
                if (letter == '<' || isAddingRichTextTags)
                {
                    isAddingRichTextTags = true;
                    _dialogueText.text += letter;
                    if (letter == '>')
                    {
                        isAddingRichTextTags = false;
                    }
                }
                else
                {
                    _dialogueText.text += letter;
                    yield return new WaitForSeconds(_typingSpeed);
                }


            }
            // actions to take after the line is displayed
            _continueIcon.SetActive(true);
            DisplayChoices();
            canContinueToNextLine = true;
        }


    }

    private void HideChoices()
    {
        foreach (GameObject choice in _choices)
        {
            choice.SetActive(false);
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = _currentStory.currentChoices;
        if(currentChoices.Count > _choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: " + currentChoices.Count );
        }
        //if(currentChoices.Count != 0)
        //{
            int index = 0;
            EventSystem.current.SetSelectedGameObject(null);
            foreach (Choice choice in currentChoices)
            {
                _choices[index].gameObject.SetActive(true);
                _choicesText[index].text = choice.text;
                index++;
            }

            for (int i = index; i < _choices.Length; i++)
            {
                _choices[i].gameObject.SetActive(false);
            }

        //}
    }

    /*private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(_choices[0].gameObject);
    }*/

    public void ContinueChoiceless()
    {
        List<Choice> currentChoices = _currentStory.currentChoices;
        if (currentChoices.Count == 0)
        {
            ContinueStory();
        }
        else
        {
            if (!canContinueToNextLine)
            {
                StopCoroutine(_displayLineCoroutine);
                _dialogueText.text = _line;
                _continueIcon.SetActive(true);
                DisplayChoices();
                canContinueToNextLine = true;
            }
        }
    }
    public void MakeChoice(int choiceIndex)
    {
        if (canContinueToNextLine)
        {
            _currentStory.ChooseChoiceIndex(choiceIndex);
            ContinueStory();
        }
    }

    public Ink.Runtime.Object GetVariableState(string variableName)
    {
        Ink.Runtime.Object variableValue = null;
        DialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if(variableValue == null)
        {
            Debug.LogWarning("Ink Variable was found to be null" + variableName);
        }
        return variableValue;
    }

    public void SetVariableState(string variableName, Value value)
    {
        _currentStory.variablesState.SetGlobal(variableName, value);
    }

    public void GoToKnot(string knotName)
    {
        try
        {
            _currentStory.ChoosePathString(knotName);
            canContinueToNextLine = true;
            ContinueStory();
        }
        catch (System.Exception)
        {
            try
            {
                _currentStory.ResetState();
                DialogueVariables.GetInstance().VariablesToStory(_currentStory);
                _currentStory.ChoosePathString(knotName);
                canContinueToNextLine = true;
                ContinueStory();
            }
            catch (System.Exception)
            {
                Debug.LogError("Failed to jump to Ink knot" + knotName);
            }
        }
    }
}
