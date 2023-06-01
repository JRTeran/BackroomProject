using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Fotograma : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.url = "C:/Users/chuy-/BacktoomsJRTC/Assets/Sounds/Crab Rave - Backrooms Edition.mp4";
        videoPlayer.Prepare();
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
        videoPlayer.time = 0;
        videoPlayer.started += SetStartTime;
    }

    void SetStartTime(VideoPlayer vp)
    {
        vp.started -= SetStartTime;
        vp.time = 2f; // Set the start time to 2 seconds
    }
}

