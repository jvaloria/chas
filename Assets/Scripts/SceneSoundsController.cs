using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SceneSoundsController : MonoBehaviour
{
    [SerializeField] private AudioClip SceneBGM;
    [SerializeField] private float SceneBGMVolume = 1f;
    [SerializeField] private List<AudioClip> SceneSounds;
    void Start()
    {
        SoundManager.PlayBGM(SceneBGM, SceneBGMVolume);
    }

    public AudioClip getSound(string soundName)
    {
        foreach (var sound in SceneSounds)
        {
            if (sound.name == soundName)
            {
                return sound;
            }
        }
        return null;
    }
}
