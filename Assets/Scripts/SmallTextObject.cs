using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallTextObject : MonoBehaviour
{
    [SerializeField] private CanvasGroup target;
    public float fadeDuration = 1f;
    public void OnClick()
    {
        //Debug.Log("SmallTextObject clicked: " + gameObject.name);
        target.alpha = 1f;
        StartCoroutine(FadeOutImage());
    }

    public IEnumerator FadeOutImage()
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, t / fadeDuration);
            target.alpha = alpha;
            t += Time.deltaTime;
            yield return null;
        }

        // Ensure alpha is exactly 0 at the end
        target.alpha = 0f;
    }
}
