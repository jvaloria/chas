public class CartelCalle : InteractableObject
{
    protected override void CustomAction()
    {
        DialogueVariables.GetInstance().SetBoolVariable("cartelCalle", true);
        //gameObject.SetActive(false);
    }
}
