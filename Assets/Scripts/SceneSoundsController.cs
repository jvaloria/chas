using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SceneSoundsController : MonoBehaviour
{
    [SerializeField] private AudioClip SceneBGM;
    [SerializeField] private float SceneBGMVolume = 1f;
    [SerializeField] private List<AudioClip> SceneSounds;
    // Start is called before the first frame update
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
       /* foreach (InteractableObject obj in interactableObjects)
        {
            if (obj.name == objectName)
            {
                obj.gameObject.SetActive(true);
                break;
            }
        }*/
}
