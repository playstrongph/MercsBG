using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkillsDisplay : MonoBehaviour, IShowSkillsDisplay
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;

   private ISkillVisuals _skillPanelInUse = null;


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
      var heroSkills = hero.HeroSkills.AllSkills;
      
      //Default is three skills
      _skillPanelInUse = threeSkillPanel;

      //Select Skill Panel Template - 3 or 4-skill panel
      if (heroSkillsCount < 4)
      {
        fourSkillPanel.Transform.gameObject.SetActive(false);
        threeSkillPanel.Transform.gameObject.SetActive(true);

        _skillPanelInUse = threeSkillPanel;
      }
      else
      {
         fourSkillPanel.Transform.gameObject.SetActive(true);
         threeSkillPanel.Transform.gameObject.SetActive(false);
         
         _skillPanelInUse = fourSkillPanel;
      }
      
      //Set Frame Color of skill panel based on hero class
      hero.HeroInformation.HeroClass.SetSkillPanelFrameColor(_skillPanelInUse.SkillPanelFrames);

      for (int i = 0; i < heroSkillsCount; i++)
      {
         var skillVisual = _skillPanelInUse.HeroSkillVisuals[i];
         var heroSkill = heroSkills[i];
         var skillCooldown = heroSkill.SkillAttributes.SkillCooldown;
         
         //Set Text
         skillVisual.CooldownText.text = heroSkill.SkillAttributes.SkillCooldown.ToString();
         skillVisual.SpeedText.text = heroSkill.SkillAttributes.SkillSpeed.ToString();
         
         //Set Graphics
         skillVisual.SkillReadyGraphic.sprite = heroSkill.SkillAttributes.SkillSprite;
         skillVisual.SkillNotReadyGraphic.sprite = heroSkill.SkillAttributes.SkillSprite;
         skillVisual.PassiveSkillGraphic.sprite = heroSkill.SkillAttributes.SkillSprite;

         //TODO: Set Skill Frame based on skilltype
         heroSkill.SkillAttributes.SkillType.SetSkillFrame(skillVisual,skillCooldown);
         
         //TODO: If there will be no individual skill speed, disable in the game object
         skillVisual.SpeedText.enabled = heroSkill.SkillAttributes.SkillSpeed > 0;




      }
      
      

   }






   #endregion
}
