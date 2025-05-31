using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] protected bool playsSound;
    [SerializeField] private bool hasCustomAction;
    [SerializeField] private bool isUsedOnce;
    private bool _alreadyUsed = false;
    [SerializeField] private AudioClip objectAudio;
    [SerializeField] private bool continuesStory;
    [SerializeField] private string storyKnot;
    [SerializeField] private bool activatesOther;
    [SerializeField] private InteractableObject otherInteractableObject;

    public void OnClick()
    {
        //Debug.Log("InteractableObject clicked: " + gameObject.name);
        if (!_alreadyUsed)
        {
            if (isUsedOnce)
            {
                _alreadyUsed = true;
            }
            if (playsSound)
            {
                SoundManager.PlaySFX(objectAudio);
            }
            if (hasCustomAction)
            {
                CustomAction();
            }
            if (continuesStory)
            {
                ContinueStory();
            }
            if (activatesOther)
            {
                ObjectManager.GetInstance().EnableObject(otherInteractableObject.gameObject);
            }
        }

    }

    protected virtual void CustomAction()
    {
        Debug.Log("custom action override method not implemented");
    }

    private void ContinueStory()
    {
        if(storyKnot != "")
        {
            DialogueManager.GetInstance().GoToKnot(storyKnot);
        }
        else
        {
            DialogueManager.GetInstance().ContinueStory();
        }
    }

}
