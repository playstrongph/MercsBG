using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroFrames : MonoBehaviour, IHeroFrames
{
   #region VARIABLES

   [SerializeField] private List<Sprite> frames = new List<Sprite>();

   [SerializeField] private Image frameImage = null;

   #endregion

   #region PROPERTIES
   private List<Sprite> Frames => frames;

   private Image FrameImage => frameImage;

   #endregion

   #region METHODS

   public void SetColorRedDefender()
   {
      //Element 0 is Red
      frameImage.sprite = Frames[0];
   }
   
   public void SetColorGreenFighter( )
   {
      //Element 1 is Green
      frameImage.sprite = Frames[1];
   }
   
   public void SetColorBlueCaster( )
   {
      //Element 2 is Blue
      frameImage.sprite = Frames[2];
   }
   
   public void SetColorGreyDefault( )
   {
      //Element 3 is Grey
      frameImage.sprite = Frames[3];
   }
   
   



   #endregion
}
