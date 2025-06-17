using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] List<InteractableObject> interactableObjects;

    public void EnableObject(string objectName)
    {
        foreach (InteractableObject obj in interactableObjects)
        {
            if (obj.name == objectName)
            {
                obj.gameObject.SetActive(true);
                break;
            }
        }
    }
    public void DisableObject(string objectName)
    {
        foreach (InteractableObject obj in interactableObjects)
        {
            if (obj.name == objectName)
            {
                obj.gameObject.SetActive(false);
                break;
            }
        }
    }

    public void FadeOutObject(string objectName, float duration)
    {
        foreach (InteractableObject obj in interactableObjects)
        {
            if (obj.name == objectName)
            {
                StartCoroutine(FadeOutObject(obj, duration));
                break;
            }
        }


    }
    private IEnumerator FadeOutObject(InteractableObject obj, float duration)
    {
        CanvasRenderer renderer = obj.GetComponent<CanvasRenderer>();
        if (renderer == null) yield break;
        float startAlpha = renderer.GetAlpha();
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, 0f, elapsedTime / duration);
            renderer.SetAlpha(alpha);
            yield return null;
        }
        renderer.SetAlpha(0f);
        obj.gameObject.SetActive(false);
    }

    public void FadeInObject(string objectName, float duration)
    {
        Debug.Log($"Fading in object: {objectName} over {duration} seconds");
        foreach (InteractableObject obj in interactableObjects)
        {
            if (obj.name == objectName)
            {
                Debug.Log("Fading in object");
                StartCoroutine(FadeInObject(obj, duration));
                break;
            }
        }

    }
    private IEnumerator FadeInObject(InteractableObject obj, float duration)
    {
        CanvasRenderer renderer = obj.GetComponent<CanvasRenderer>();
        if (renderer == null) yield break;
        obj.gameObject.SetActive(true);
        renderer.SetAlpha(0f); // Ensure starts fully transparent
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / duration);
            renderer.SetAlpha(alpha);
            yield return null;
        }
        renderer.SetAlpha(1f);
    }
}
