public class DevilCatCasaEmbrujada : InteractableObject
{
    protected override void CustomAction()
    {
        DialogueVariables.GetInstance().SetBoolVariable("devilCatMansion", true);
        gameObject.SetActive(false);
    }
}
