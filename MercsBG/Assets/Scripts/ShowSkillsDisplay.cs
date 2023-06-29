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
      HeroSkillsDisplay.Canvas.enabled = false;
   }

   private void UpdateDisplayInformation(IHero hero)
   {
      var heroSkillsCount = hero.HeroSkills.InUseHeroSkills;
      var threeSkillPanel = HeroSkillsDisplay.ThreeSkillVisuals;
      var fourSkillPanel = HeroSkillsDisplay.FourSkillVisuals;
      
      var skillPanelInUse = threeSkillPanel; //Default is 3 skills
      
      //Select Skill Panel Template - 3 or 4-skill panel
      if (heroSkillsCount < 4)
      {
        fourSkillPanel.Transform.gameObject.SetActive(false);
        threeSkillPanel.Transform.gameObject.SetActive(true);

        

        skillPanelInUse = threeSkillPanel;
      }
      else
      {
         fourSkillPanel.Transform.gameObject.SetActive(true);
         threeSkillPanel.Transform.gameObject.SetActive(false);
         
         skillPanelInUse = fourSkillPanel;
      }

      for (int i = 0; i < heroSkillsCount; i++)
      {
         //TODO: Set Cooldown Text, 
      }
      
      

   }






   #endregion
}
