using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectManager : MonoBehaviour
{
    private static ObjectManager _instance;

    private void Awake()
    {
        _instance = this;
    }

    public static ObjectManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameObject().AddComponent<ObjectManager>();
            DontDestroyOnLoad(_instance.gameObject);

        }
        return _instance;
    }

    public void EnableObject(string objectName)
    {
        GameObject.FindFirstObjectByType<ObjectController>().EnableObject(objectName);
    }
    public void DisableObject(string objectName)
    {
        GameObject.FindFirstObjectByType<ObjectController>().DisableObject(objectName);
    }
    public void FadeOutObject(string objectName, float duration = 1f)
    {
        GameObject.FindFirstObjectByType<ObjectController>().FadeOutObject(objectName, duration);
    }

    public void FadeInObject(string objectName, float duration = 1f)
    {
        GameObject.FindFirstObjectByType<ObjectController>().FadeInObject(objectName, duration);
    }

    public void EnableObject(GameObject objeto)
    {
        objeto.SetActive(true);
    }

    public void DisableObject(GameObject objeto)
    {
        objeto.SetActive(false);
    }


}
