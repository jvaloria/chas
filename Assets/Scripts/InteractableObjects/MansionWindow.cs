using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GifImporter;

public class MansionWindow : InteractableObject
{
    [SerializeField] private List<MansionWindow> neighborWindows;
    /*[SerializeField] private Sprite onSprite;
    [SerializeField] private Sprite offSprite;
    [SerializeField] private Sprite devilSprite;*/
    [SerializeField] private GameObject onSpriteObject;
    [SerializeField] private GameObject offSpriteObject;
    [SerializeField] private GameObject devilSpriteObject;
    [SerializeField] private bool onOff;
    [SerializeField] WindowCounter windowCounter;
    private bool isDeviled = false;


    protected override void CustomAction()
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
            offSpriteObject.GetComponent<GifPlayer>().PlayOnceForward();
            onSpriteObject.SetActive(false);
            windowCounter.CounterDown();
        }
        else
        {
            onOff = true;
            offSpriteObject.GetComponent<GifPlayer>().PlayOnceReverse();
            //offSpriteObject.SetActive(false);
            onSpriteObject.SetActive(true);
            //GetComponent<Image>().sprite = onSprite;
            windowCounter.CounterUp();
        }
    }

    public void setDevil()
    {
        isDeviled = true;
        onSpriteObject.SetActive(false);
        //offSpriteObject.SetActive(false);
        devilSpriteObject.SetActive(true);
        //GetComponent<Image>().sprite = devilSprite;
        playsSound = false;
    }
}
