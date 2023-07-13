using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroGlows : MonoBehaviour, IHeroGlows
{
   #region VARIABLES

   [SerializeField] private Image heroGlow = null;
   
   [SerializeField] private string redHexCode = "#FF1300";
   [SerializeField] private string greenHexCode = "#BFFF84";
   [SerializeField] private string yellowHexCode = "#FFE364";

   #endregion

   #region PROPERTIES

   private Image HeroGlow => heroGlow;


   #endregion

   #region METHODS

   public void ShowHeroGlow()
   {
      Debug.Log("Show Hero Glow");
      
      HeroGlow.enabled = true;
   }
   
   public void HideHeroGlow()
   {
      
      Debug.Log("Hide Hero Glow");
      
      HeroGlow.enabled = false;
   }
   
   
   /// <summary>
   /// Red if target is an enemy
   /// </summary>
   public void SetColorRed()
   {
      //Check if hex code is valid - if not, default to white color
      Color color = ColorUtility.TryParseHtmlString(redHexCode, out color) ? color : Color.white;
        
      // Set the image color
      HeroGlow.color = color;
   }
   
   /// <summary>
   /// Green if target is an ally
   /// </summary>
   public void SetColorGreen()
   {
      //Check if hex code is valid - if not, default to white color
      Color color = ColorUtility.TryParseHtmlString(greenHexCode, out color) ? color : Color.white;
        
      // Set the image color
      HeroGlow.color = color;
   }
   
   /// <summary>
   /// Yellow if any target
   /// </summary>
   public void SetColorYellow()
   {
      //Check if hex code is valid - if not, default to white color
      Color color = ColorUtility.TryParseHtmlString(yellowHexCode, out color) ? color : Color.white;
        
      // Set the image color
      HeroGlow.color = color;
   }


   #endregion
}
