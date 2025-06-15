using UnityEngine;

public class CartelCalle : InteractableObject
{
    protected override void CustomAction()
    {
        Debug.Log("Cartel Calle Interacted");
        DialogueVariables.GetInstance().SetBoolVariable("cartelCalle", true);
        //gameObject.SetActive(false);
    }
}
