using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class VideoPlayerPrograssBar : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    public RectTransform rectTransform;
    public Image progressBar;
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
   public void OnDrag(PointerEventData eventData)
   {
       Skip(eventData);


   }
   public void OnPointerDown(PointerEventData eventData)
   {
       Skip(eventData);

   }

   private void Skip(PointerEventData eventData)
   {
       Vector3 localPoint = rectTransform.InverseTransformPoint (eventData.pointerCurrentRaycast.worldPosition);
       float percent = Mathf.InverseLerp(progressBar.rectTransform.rect.xMin, progressBar.rectTransform.rect.xMax, localPoint.x);
       float frame = videoPlayer.frameCount * percent;
       videoPlayer.frame = (long)frame;

   }

   private void Update()
  {
     if(videoPlayer.frameCount > 0)
     {
         progressBar.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
         
     }
  } 
}
