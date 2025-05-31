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
    private void Start()
    {
        OnClicked();
    }
    public void OnClicked()
    {
        if (started)
        {
            DialogueManager.GetInstance().ContinueChoiceless();
        }
        else
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            started = true;
        }
    }
}
