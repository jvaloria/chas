using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager _instance;

    [Header("DialogueUI")]
    [SerializeField] private GameObject _dialoguePanel;
    [SerializeField] private TextMeshProUGUI _dialogueText;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] _choices;
    [SerializeField] private TextMeshProUGUI[] _choicesText;

    private Story currentStory;
    bool _dialogueIsPlaying;

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
        currentStory = new Story(inkJSON.text);
        _dialogueIsPlaying = true;
        _dialoguePanel.SetActive(true);

        currentStory.BindExternalFunction("loadScreen", (int screenToLoad) =>
        {
            SceneManager.LoadScene(screenToLoad);
        });

        ContinueStory();
    }

    private void ExitDialogueMode()
    {
        currentStory.UnbindExternalFunction("loadScreen");
        _dialogueIsPlaying = false;
        _dialoguePanel.SetActive(false);
        _dialogueText.text = "";

    }


    static public DialogueManager GetInstance()
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
                if (currentStory.canContinue)
                {
                    //set text for the dialogue line
                    _dialogueText.text = currentStory.Continue();
                    //set text for the options
                    DisplayChoices();
                }
                else
                {
                    ExitDialogueMode();
                }
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;
        if(currentChoices.Count > _choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: " + currentChoices.Count );
        }
        //if(currentChoices.Count != 0)
        //{
            int index = 0;
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

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(_choices[0].gameObject);
    }

    public void ContinueChoiceless()
    {
        List<Choice> currentChoices = currentStory.currentChoices;
        if (currentChoices.Count == 0)
        {
            ContinueStory();
        }
    }
    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
        ContinueStory();
    }

}
