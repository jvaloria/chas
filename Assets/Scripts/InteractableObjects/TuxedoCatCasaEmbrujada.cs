using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuxedoCatCasaEmbrujada : InteractableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CustomAction()
    {
        DialogueVariables.GetInstance().SetBoolVariable("tuxedoCatMansion", true);
        gameObject.SetActive(false);
    }
}
