using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        //demorado con invoke porque sino no triggereaba en la build
        Invoke("OnClicked", 0.1f);
    }
    public void OnClicked()
    {
        if (started)
        {
            var dialogueManager = DialogueManager.GetInstance();
            dialogueManager.ContinueChoiceless();
        }
        else
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            started = true;
        }
    }
}
