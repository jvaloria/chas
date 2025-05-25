using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclista : MonoBehaviour
{
    [SerializeField] float SpeedX;
    [SerializeField] float SpeedY;
    [SerializeField] float SpeedSizeIncrease;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(SpeedX * Time.deltaTime + transform.position.x, SpeedY * Time.deltaTime + transform.position.y, transform.position.z);
        transform.localScale = new Vector3(SpeedSizeIncrease * Time.deltaTime + transform.localScale.x, SpeedSizeIncrease * Time.deltaTime + transform.localScale.y, SpeedSizeIncrease * Time.deltaTime + transform.localScale.z);
        if(transform.position.x < -13f)
        {
            gameObject.SetActive(false);
        }
    }
}
