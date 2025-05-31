public class TuxedoCatCasaEmbrujada : InteractableObject
{
    protected override void CustomAction()
    {
        DialogueVariables.GetInstance().SetBoolVariable("tuxedoCatMansion", true);
        gameObject.SetActive(false);
    }
}
