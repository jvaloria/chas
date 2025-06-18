using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSceneStarter : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public ScreenFader screenFader;

    private void Start()
    {
        StartCoroutine(PrepareVideoAndFadeIn());
    }

    IEnumerator PrepareVideoAndFadeIn()
    {
        videoPlayer.Prepare();

        while (!videoPlayer.isPrepared)
            yield return null;

        videoPlayer.Play();

         yield return screenFader.StartCoroutine(screenFader.FadeFromBlack());
    }
}
