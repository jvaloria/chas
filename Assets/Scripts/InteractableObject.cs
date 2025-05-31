using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private bool playsSound;
    [SerializeField] private bool hasCustomAction;
    [SerializeField] private bool isUsedOnce;
    [SerializeField] private AudioSource objectAudio;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onInteraction()
    {
        if (isUsedOnce)
        {
            this.gameObject.SetActive(false);
        }
        if (playsSound)
        {
            SoundManager.PlaySFX(objectAudio.clip);
        }

    }

    public virtual void CustomAction()
    {
        Debug.Log("custom action override method not implemented");
        return;
    }

    
}
