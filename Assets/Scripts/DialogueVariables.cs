using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using Unity.VisualScripting;
using Ink.UnityIntegration;

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
    [SerializeField] private InkFile globalsInkFile;

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
        string inkFileContents = File.ReadAllText (globalsInkFile.filePath);
        Ink.Compiler compiler = new Ink.Compiler(inkFileContents);
        globalVariablesStory = compiler.Compile();
        VariablesToStory(globalVariablesStory);
        foreach (string name in globalVariablesStory.variablesState)
        {
            Ink.Runtime.Object value =  globalVariablesStory.variablesState.GetVariableWithName (name);
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
        //viejotest = true;
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

}
