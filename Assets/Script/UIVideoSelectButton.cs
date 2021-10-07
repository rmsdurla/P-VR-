using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class UIVideoSelectButton : MonoBehaviour
{
  public VideoClip videoClip;
  public VideoPlayerController videoPlayerController;

  public void OnClick()
  {
    videoPlayerController.ChangeVideo(videoClip);

  }
}
