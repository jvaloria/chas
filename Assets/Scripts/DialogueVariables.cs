using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using Unity.VisualScripting;
// Esto tira error si lo descomento, no sé por qué
//using Ink.Parsed;

public class DialogueVariables : MonoBehaviour
{
    private static DialogueVariables _instance;

    public static DialogueVariables GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameObject().AddComponent<DialogueVariables>();
            DontDestroyOnLoad(_instance.gameObject);

        }
        return _instance;
    }
    //[SerializeField] private InkFile globalsInkFile;
    [SerializeField] private TextAsset globalsInkFile;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public static Dictionary<string, Ink.Runtime.Object> variables { get; private set; } = new Dictionary<string, Ink.Runtime.Object>();
    private Story globalVariablesStory;

    public void Start()
    {
        globalVariablesStory = new Story(globalsInkFile.text);
        VariablesToStory(globalVariablesStory);
        foreach (string name in globalVariablesStory.variablesState)
        {
            Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name);
            if (variables.ContainsKey(name))
            {
                variables.Remove(name);
                variables.Add(name, value);
            }
            else
            {
                variables.Add(name, value);
            }

        }
    }

    /*public DialogueVariables(TextAsset loadGlobalsJSON)
    {
        // create the story
        Story globalVariablesStory = new Story(loadGlobalsJSON.text);

        // initialize the dictionary
        variables = new Dictionary<string, Ink.Runtime.Object>();
        foreach (string name in globalVariablesStory.variablesState)
        {
            Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name);
            variables.Add(name, value);
            Debug.Log("Initialized global dialogue variable: " + name + " = " + value);
        }
    }*/

    public void StartListening(Story story)
    {
        VariablesToStory(story);
        story.variablesState.variableChangedEvent += VariableChanged;
    }
    public void StopListening(Story story)
    {
        story.variablesState.variableChangedEvent -= VariableChanged;
    }
    public void VariableChanged(string name, Ink.Runtime.Object value)
    {
        if (variables.ContainsKey(name))
        {
            variables.Remove(name);
            variables.Add(name, value);
        }
        else
        {
            variables.Add(name, value);
        }
    }

    public void VariablesToStory(Story story)
    {
        foreach (KeyValuePair<string, Ink.Runtime.Object> variable in variables)
        {
            story.variablesState.SetGlobal(variable.Key, variable.Value);
        }
    }

    public void SetBoolVariable(string name, bool boolean)
    {
        if (variables.ContainsKey(name))
        {
            variables[name] = Value.Create(boolean);
        }
        else
        {
            variables.Add(name, Value.Create(boolean));
        }
        globalVariablesStory.variablesState.SetGlobal(name, Value.Create(boolean));
        DialogueManager.GetInstance().SetVariableState(name, Value.Create(boolean));
    }

    // FIXME: Esto tira error si lo descomento, no sé por qué
    /*public void ResetVariables()
    {
        foreach (KeyValuePair<string, Ink.Runtime.Object> variable in variables)
        {
            variables[variable.Key] = Value.Create(false);
        }
        VariablesToStory(globalVariablesStory);
    }*/

}
