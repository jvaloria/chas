using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MansionWindow : InteractableObject
{
    [SerializeField] private List<MansionWindow> neighborWindows;
    [SerializeField] private Sprite onSprite;
    [SerializeField] private Sprite offSprite;
    [SerializeField] private Sprite devilSprite;
    [SerializeField] private bool onOff;
    [SerializeField] WindowCounter windowCounter;
    private bool isDeviled = false;


    public override void CustomAction()
    {
        if (!isDeviled)
        {
            TurnOnOff();
            foreach (var neighborWindow in neighborWindows)
            {
                neighborWindow.TurnOnOff();
            }
            windowCounter.DevilCheck();
        }
    }

    public void TurnOnOff()
    {
        if (onOff)
        {
            onOff = false;
            GetComponent<Image>().sprite = offSprite;
            windowCounter.CounterDown();
        }
        else
        {
            onOff = true;
            GetComponent<Image>().sprite = onSprite;
            windowCounter.CounterUp();
        }
    }

    public void setDevil()
    {
        isDeviled = true;
        GetComponent<Image>().sprite = devilSprite;
        playsSound = false;
    }
}
