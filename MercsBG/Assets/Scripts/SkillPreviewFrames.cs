using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPreviewFrames : MonoBehaviour, ISkillPreviewFrames
{
   #region VARIABLES

   [SerializeField] private List<Sprite> frames = new List<Sprite>();
   [SerializeField] private Image skillPreviewFrame = null;
   
   
   #endregion

   #region PROPERTIES

   private List<Sprite> Frames => frames;

   private Image SkillPreviewFrame => skillPreviewFrame;

   #endregion

   #region METHODS

   public void SetColorRedDefender()
   {
      //Element 0 is Red
      SkillPreviewFrame.sprite = Frames[0];
   }
   
   public void SetColorGreenFighter()
   {
      //Element 1 is Green
      SkillPreviewFrame.sprite = Frames[1];
   }
   
   public void SetColorBlueCaster()
   {
      //Element 2 is Blue
      SkillPreviewFrame.sprite = Frames[2];
   }
   
   public void SetColorGreyDefault()
   {
      //Element 3 is Grey
      SkillPreviewFrame.sprite = Frames[3];
   }


   #endregion
}
