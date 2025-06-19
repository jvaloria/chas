using Ink.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class VolumeUI : MonoBehaviour
{
    public GameObject sliderContainer;
    public Slider bgmSlider;
    public Slider sfxSlider;
    [SerializeField] AudioSource MenuBGMusic;

    private const string BGM_PREF_KEY = "BGM_VOLUME";
    private const string SFX_PREF_KEY = "SFX_VOLUME";

    private void Start()
    {
        float bgmVolume = PlayerPrefs.GetFloat(BGM_PREF_KEY, 1f);
        float sfxVolume = PlayerPrefs.GetFloat(SFX_PREF_KEY, 1f);

        bgmSlider.value = bgmVolume;
        sfxSlider.value = sfxVolume;
        MenuBGMusic.volume = bgmVolume;

        SoundManager.SetBGMVolume(bgmVolume);
        SoundManager.SetSFXVolume(sfxVolume);

        bgmSlider.onValueChanged.AddListener(OnBGMVolumeChanged);
        sfxSlider.onValueChanged.AddListener(OnSFXVolumeChanged);

        sliderContainer.SetActive(false);
    }

    public void ToggleSliders()
    {
        sliderContainer.SetActive(!sliderContainer.activeSelf);
    }

    private void OnBGMVolumeChanged(float value)
    {
        SoundManager.SetBGMVolume(value);
        PlayerPrefs.SetFloat(BGM_PREF_KEY, value);
        MenuBGMusic.volume = value; // Update the menu background music volume
    }

    private void OnSFXVolumeChanged(float value)
    {
        SoundManager.SetSFXVolume(value);
        PlayerPrefs.SetFloat(SFX_PREF_KEY, value);
    }
}