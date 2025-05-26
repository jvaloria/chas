using UnityEngine;

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
        GameObject spawnableObject = transform.Find(objectName).gameObject;
        // Enable the object
        spawnableObject.SetActive(true);
    }
    public void DisableObject(string objectName)
    {
        GameObject spawnableObject = transform.Find(objectName).gameObject;
        // Enable the object
        spawnableObject.SetActive(false);
    }


}
