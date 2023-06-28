using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkillsDisplay : MonoBehaviour, IShowSkillsDisplay
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;
   
   


   #endregion

   #region PROPERTIES
   
   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkillsDisplay as IHeroSkillsDisplay;


   #endregion

   #region METHODS

   public void DisplayOn(IHero hero)
   {
      HeroSkillsDisplay.Canvas.enabled = true;
      
      UpdateDisplayInformation(hero);
   }

   public void DisplayOff(IHero hero)
   {
      HeroSkillsDisplay.Canvas.enabled = true;
   }

   private void UpdateDisplayInformation(IHero hero)
   {
      var heroSkills = hero.HeroSkills.AllSkills;

      if (heroSkills.Count < 4)
      {
         var skillPanel = HeroSkillsDisplay.ThreeSkillVisuals.HeroSkillVisuals;
      }
      else
      {
         var skillPanel = HeroSkillsDisplay.FourSkillVisuals.HeroSkillVisuals;
      }
   }






   #endregion
}
