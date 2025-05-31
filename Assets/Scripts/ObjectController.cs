using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] List<InteractableObject> interactableObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
