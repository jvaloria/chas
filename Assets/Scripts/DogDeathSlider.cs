using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogDeathSlider : MonoBehaviour
{
    [SerializeField] private Slider deathSlider;
    private float sliderDuration;
    private float timeSinceStart;
    private float progress;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject fillArea;
    [SerializeField] private GameObject handleSlideArea;
    public void CheckForDeath()
    {
        
    }
    public void StartSlider(float duration)
    {
        sliderDuration = duration;
        timeSinceStart = 0;
        background.SetActive(true);
        fillArea.SetActive(true);
        handleSlideArea.SetActive(true);
    }
    public void StopSlider()
    {
        this.gameObject.SetActive(false);
        //por ahora no hace falta, lo apaga el dialogueManager
    }

    private void Update()
    {
        timeSinceStart += Time.deltaTime;
        progress = timeSinceStart / sliderDuration;
        deathSlider.value = Mathf.Clamp01(progress);
        if (deathSlider.value >= deathSlider.maxValue)
        {
            DialogueManager.GetInstance().MakeChoice(2);
        }
    }
}
