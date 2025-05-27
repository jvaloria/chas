using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractionsManager : MonoBehaviour
{
    public Image flashImage;
    public float flashDuration = 0.1f;
    public float fadeDuration = 0.2f;
    public Color flashColor = Color.white;

    private void Start()
    {
        if (!flashImage)
        {
            Debug.LogError("Flash Image not assigned to script!");
            enabled = false; // Disable the script if no image is assigned
            return;
        }
        // Ensure it starts invisible
        flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, 0f);
    }

    // The UI Button will call this public method
    public void TriggerFlash()
    {
        if (flashImage)
        {
            StartCoroutine(FlashCoroutine());
        }
    }

    private IEnumerator FlashCoroutine()
    {
        // Set to full alpha
        flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, 1f);

        // Wait for the flash duration
        yield return new WaitForSeconds(flashDuration);

        // Fade out
        var elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            var alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, alpha);
            yield return null; // Wait for the next frame
        }

        // Ensure it's fully transparent
        flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, 0f);
    }
}
