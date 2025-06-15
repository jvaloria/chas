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
}
