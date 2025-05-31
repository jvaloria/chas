using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuxedoCatCasaEmbrujada : InteractableObject
{
    public override void CustomAction()
    {
        DialogueVariables.GetInstance().SetBoolVariable("tuxedoCatMansion", true);
        gameObject.SetActive(false);
    }
}
