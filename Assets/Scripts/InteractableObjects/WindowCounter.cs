using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowCounter : MonoBehaviour
{
    private int counter;
    [SerializeField] private MansionWindow[] windows = new MansionWindow[5];
    // Start is called before the first frame update
    void Start()
    {
        counter = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CounterUp()
    {
        counter++;
    }
    public void CounterDown()
    {
        counter--;
    }
    public void DevilCheck()
    {
        Debug.Log("DevilCheck called, current counter: " + counter);
        if (counter == 5)
        {
            foreach (var window in windows)
            {
                window.setDevil();
            }
        }
    }
}
