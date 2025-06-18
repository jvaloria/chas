using UnityEngine;

public class ImageSceneStarter : MonoBehaviour
{
    public ScreenFader screenFader;
    public float delayBeforeFade = 0.5f; // Adjust as needed

    private void Start()
    {
        StartCoroutine(FadeInAfterDelay());
    }

    private System.Collections.IEnumerator FadeInAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeFade);
        yield return screenFader.StartCoroutine(screenFader.FadeFromBlack());
    }
}
