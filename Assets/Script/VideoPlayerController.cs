using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    
    public void Stop()
    {
        videoPlayer.Stop();

    }

    public void Run()
    {
        videoPlayer.Play();

    }

    public void Pause()
    {
        videoPlayer.Pause();
    }

    public void ChangeVideo(VideoClip videoClip)
    {
        Stop();
        videoPlayer.clip = videoClip; 
    }
}
