using UnityEngine;
using System.Collections;

public class GlitchEffect : MonoBehaviour
{
    public float glitchInterval = 0.1f; // Time in seconds between toggles
    private SpriteRenderer spriteRenderer;
    private bool isVisible = true;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer not found on this GameObject.");
            enabled = false; // Disable the script if no SpriteRenderer is found
            return;
        }
        StartCoroutine(GlitchCoroutine());
    }

    private IEnumerator GlitchCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(glitchInterval);
            isVisible = !isVisible;
            spriteRenderer.enabled = isVisible;
        }
    }
}
