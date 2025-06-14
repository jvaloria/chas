using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFader : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1f;

    void Start()
    {
        StartCoroutine(FadeFromBlack());
    }

    public IEnumerator FadeToBlack()
    {
        this.gameObject.GetComponent<Canvas>().enabled = true;
        float time = 0f;
        Color color = fadeImage.color;

        while (time < fadeDuration)
        {
            color.a = Mathf.Lerp(0f, 1f, time / fadeDuration);
            fadeImage.color = color;
            time += Time.deltaTime;
            yield return null;
        }

        color.a = 1f;
        fadeImage.color = color;
    }

    public IEnumerator FadeFromBlack()
    {
        float time = 0f;
        Color color = fadeImage.color;

        while (time < fadeDuration)
        {
            color.a = Mathf.Lerp(1f, 0f, time / fadeDuration);
            fadeImage.color = color;
            time += Time.deltaTime;
            yield return null;
        }

        color.a = 0f;
        fadeImage.color = color;
        this.gameObject.GetComponent<Canvas>().enabled = false;
    }
}
