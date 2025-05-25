using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedOptionSlider : MonoBehaviour
{
    [SerializeField] private Slider _respawnBar;
    [SerializeField] private GameObject _button;
    [SerializeField] private float _actionableTime;
    private float _timePassed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _timePassed += Time.deltaTime;
        _respawnBar.value = 1- _timePassed / _actionableTime;
        if (_timePassed > _actionableTime)
        {
            _button.SetActive(false);
        }
    }

    public void EnableTimer(float timerTime)
    {
        gameObject.SetActive(true);
        _timePassed = 0f;
        _actionableTime = timerTime;
    }

    public void DisableTimer()
    {
        gameObject.SetActive(false);
        _timePassed = 0f;
        _actionableTime = 10f;
    }
}
