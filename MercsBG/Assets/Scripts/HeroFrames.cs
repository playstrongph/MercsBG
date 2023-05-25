using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroFrames : MonoBehaviour, IHeroFrames
{
   #region VARIABLES

   [SerializeField] private List<Sprite> frames = new List<Sprite>();


   #endregion

   #region PROPERTIES
   private List<Sprite> Frames => frames;

   #endregion

   #region METHODS
   
   public void SetColorRedDefender(Image image)
   {
      //Element 0 is Red
      image.sprite = Frames[0];
   }
   
   public void SetColorGreenFighter(Image image)
   {
      //Element 1 is Green
      image.sprite = Frames[1];
   }
   
   public void SetColorBlueCaster(Image image)
   {
      //Element 2 is Blue
      image.sprite = Frames[2];
   }
   
   public void SetColorGreyDefault(Image image)
   {
      //Element 3 is Grey
      image.sprite = Frames[3];
   }
   
   



   #endregion
}
