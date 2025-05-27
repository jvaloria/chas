using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Image
using System.Collections; // Required for Coroutines

public class InteractionsManager : MonoBehaviour
{
    public Image flashImage; // Assign your LightningFlashImage here in the Inspector
    public float flashDuration = 0.1f; // How long the flash stays at full intensity
    public float fadeDuration = 0.2f; // How long it takes to fade out
    public Color flashColor = Color.white; // The color of the flash

    void Start()
    {
        if (flashImage == null)
        {
            Debug.LogError("Flash Image not assigned to LightningFlashEffect script!");
            enabled = false; // Disable script if no image is assigned
            return;
        }
        // Ensure it starts invisible
        flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, 0f);
    }

    // This public method will be called by the UI Button
    public void TriggerFlash()
    {
        if (flashImage != null)
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
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, alpha);
            yield return null; // Wait for the next frame
        }

        // Ensure it's fully transparent
        flashImage.color = new Color(flashColor.r, flashColor.g, flashColor.b, 0f);
    }
}
