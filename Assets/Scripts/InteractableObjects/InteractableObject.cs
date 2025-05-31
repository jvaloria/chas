using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] protected bool playsSound;
    [SerializeField] private bool hasCustomAction;
    [SerializeField] private bool isUsedOnce;
    private bool alreadyUsed = false;
    [SerializeField] private AudioClip objectAudio;
    [SerializeField] private bool continuesStory;
    [SerializeField] private string storyKnot;
    [SerializeField] private bool activatesOther;
    [SerializeField] private InteractableObject otherInteractableObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onInteraction()
    {
        if (!alreadyUsed)
        {
            if (isUsedOnce)
            {
                alreadyUsed = true;
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

    public virtual void CustomAction()
    {
        Debug.Log("custom action override method not implemented");
        return;
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
