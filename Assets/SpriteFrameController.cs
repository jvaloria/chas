using System.Collections;
using UnityEngine;

public class SpriteFrameController : MonoBehaviour
{
    [Header("Animation Settings")]
    public Sprite[] animationFrames;
    public SpriteRenderer spriteRenderer;
    public float frameRate = 12f;

    [Header("Target Frame Settings")]
    public int targetFirstFrame = 0;
    public int targetLastFrame = 23;

    private Coroutine playRoutine;
    [SerializeField]private int currentFrame = 0;

    public void PlayUntilFrame(int targetFrame)
    {
        if (targetFrame < 0 || targetFrame >= animationFrames.Length)
        {
            Debug.LogWarning("Target frame out of range!");
            return;
        }

        if (playRoutine != null)
            StopCoroutine(playRoutine);

        playRoutine = StartCoroutine(PlayToFrame(targetFrame));
    }

    private IEnumerator PlayToFrame(int target)
    {
        int direction = (target > currentFrame) ? 1 : -1;
        float frameDelay = 1f / frameRate;

        while (currentFrame != target)
        {
            spriteRenderer.sprite = animationFrames[currentFrame];
            currentFrame += direction;
            yield return new WaitForSeconds(frameDelay);
        }

        // Final frame
        spriteRenderer.sprite = animationFrames[currentFrame];
    }

    public void SetFrame(int frameIndex)
    {
        if (frameIndex < 0 || frameIndex >= animationFrames.Length)
            return;

        currentFrame = frameIndex;
        spriteRenderer.sprite = animationFrames[currentFrame];
    }

    /// <summary>
    /// Plays to the targetFirstFrame defined in the inspector.
    /// </summary>
    public void PlayToFirstFrame()
    {
        PlayUntilFrame(targetFirstFrame);
    }

    /// <summary>
    /// Plays to the targetLastFrame defined in the inspector.
    /// </summary>
    public void PlayToLastFrame()
    {
        PlayUntilFrame(targetLastFrame);
    }
}
