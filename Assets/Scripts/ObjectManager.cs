using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private static ObjectManager _instance;

    private void Awake()
    {
        _instance = this;
    }
    
    static public ObjectManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameObject().AddComponent<ObjectManager>();
            DontDestroyOnLoad(_instance.gameObject);

        }
        return _instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableObject(string objectName)
    {
        GameObject spawnableObject = transform.Find(objectName).gameObject;
        // Enable the object
        spawnableObject.SetActive(true);
    }
    public void disableObject(string objectName)
    {
        GameObject spawnableObject = transform.Find(objectName).gameObject;
        // Enable the object
        spawnableObject.SetActive(false);
    }


}
