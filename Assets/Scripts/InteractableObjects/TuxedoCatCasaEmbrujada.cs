using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuxedoCatCasaEmbrujada : InteractableObject
{
    protected override void CustomAction()
    {
        DialogueVariables.GetInstance().SetBoolVariable("tuxedoCatMansion", true);
        gameObject.SetActive(false);
    }
}
