using UnityEngine;
using System.Collections.Generic;

public static class SoundManager
{
    private static GameObject soundManagerObject;
    private static AudioSource bgmSource;
    private static List<AudioSource> sfxSources = new List<AudioSource>();

    private static float bgmVolume = 1f;
    private static float sfxVolume = 1f;

    private static int maxSFXSources = 10;

    static SoundManager()
    {
        soundManagerObject = new GameObject("SoundManager");
        Object.DontDestroyOnLoad(soundManagerObject);

        bgmSource = soundManagerObject.AddComponent<AudioSource>();
        bgmSource.loop = true;
    }

    public static void PlayBGM(AudioClip clip, float volume = 1f)
    {
        if (clip == null) return;

        bgmSource.clip = clip;
        bgmSource.volume = volume * bgmVolume;
        bgmSource.Play();
    }

    public static void StopBGM()
    {
        bgmSource.Stop();
    }

    public static void SetBGMVolume(float volume)
    {
        bgmVolume = Mathf.Clamp01(volume);
        bgmSource.volume = bgmVolume;
    }

    public static void SetSFXVolume(float volume)
    {
        sfxVolume = Mathf.Clamp01(volume);
    }

    public static void PlaySFX(AudioClip clip, float volume = 1f, Vector3? position = null)
    {
        if (clip == null) return;

        AudioSource source = GetAvailableSFXSource();
        if (source == null)
        {
            source = soundManagerObject.AddComponent<AudioSource>();
            sfxSources.Add(source);
        }

        source.clip = clip;
        source.volume = volume * sfxVolume;

        if (position.HasValue)
        {
            source.transform.position = position.Value;
            source.spatialBlend = 1f; // 3D
        }
        else
        {
            source.spatialBlend = 0f; // 2D
        }

        source.Play();
    }

    public static void PlaySceneSFX(string clipName)
    {
        AudioClip clip = GameObject.FindFirstObjectByType<SceneSoundsController>().getSound(clipName);
        if(clip != null)
        {
            PlaySFX(clip);
        }
    }

    private static AudioSource GetAvailableSFXSource()
    {
        foreach (var src in sfxSources)
        {
            if (!src.isPlaying)
                return src;
        }

        if (sfxSources.Count < maxSFXSources)
        {
            var newSource = soundManagerObject.AddComponent<AudioSource>();
            sfxSources.Add(newSource);
            return newSource;
        }

        return null;
    }
}
/* How to use
//Play a BGM track
SoundManager.PlayBGM(myBgmClip);

//Stop BGM
SoundManager.StopBGM();

// Set BGM and SFX volume
SoundManager.SetBGMVolume(0.5f);
SoundManager.SetSFXVolume(0.8f);

// Play a 2D SFX
SoundManager.PlaySFX(mySfxClip);

// Play a 3D SFX at a position
SoundManager.PlaySFX(mySfxClip, 1f, transform.position);
*/