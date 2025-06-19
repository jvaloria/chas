using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowCounter : MonoBehaviour
{
    private int counter;
    [SerializeField] private MansionWindow[] windows = new MansionWindow[5];

    [SerializeField] private InteractableObject otherInteractableObject;

    void Start()
    {
        counter = 2;
        if (DialogueVariables.GetInstance().GetBoolVariable("devilCatMansion"))
        {
            foreach (var window in windows)
            {
                window.setDevil();
            }
        }
    }

    public void CounterUp()
    {
        counter++;
    }
    public void CounterDown()
    {
        counter--;
    }
    public void DevilCheck()
    {
        if (counter == 5)
        {
            foreach (var window in windows)
            {
                window.setDevil();
            }
            ObjectManager.GetInstance().EnableObject(otherInteractableObject.gameObject);
            SoundManager.PlaySceneSFX("jumpScare", 0.8f);
        }
    }
}
