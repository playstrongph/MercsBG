﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "BasicSkill", menuName = "Assets/SkillType/BasicSkill")]
   public class BasicSkillAsset : SkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void LoadSkillTypeVisuals(ISkill skill)
      {
         
      }
      
      public override void SelectTarget(ISkill skill)
      {
         
      }


      public override void DisableTargetVisuals(ISkill skill)
      {
         
      }

      public override void EnableSkillTargeting(ISkill skill)
      {
         
      }  
      
      public override void SetSkillFrame(ISkillVisual skillVisual,int skillCooldown)
      {
         skillVisual.SkillReadyCanvas.enabled = true;
         skillVisual.SkillNotReadyCanvas.enabled = false;
         skillVisual.PassiveSkillCanvas.enabled = false;
      }
      
      public override void SetCooldownGraphicAndText(Image image, TextMeshProUGUI cooldownText ,int cooldown)
      {
         cooldownText.enabled = false;
         image.enabled = false;
      }
      
      public override void SetSpeedGraphicAndText(Image image, TextMeshProUGUI speedText, int speed)
      {
         if (speed <= 0)
         {
            speedText.enabled = false;
            image.enabled = false;
         }
         else
         {
            speedText.enabled = true;
            image.enabled = true;

            speedText.text = speed.ToString();
         }
      }
      
      /// <summary>
      /// Basic and Active skills can select skills
      /// </summary>
      /// <param name="skillVisualCollider"></param>
      public override void SelectSkillActions(ISkillVisualCollider skillVisualCollider)
      {
         var skillEnabledStatus = skillVisualCollider.SkillVisual.Skill.SkillAttributes.SkillEnableStatus;
         
         skillEnabledStatus.ManualSelectSkill(skillVisualCollider);
         
         //Debug.Log("Skill Type Check");
      }
      
      public override void SelectSkillTarget(ISelectSkillTarget selectSkillTarget)
      {
         var skillReadiness = selectSkillTarget.SkillTargeting.SkillVisual.Skill.SkillAttributes.SkillEnableStatus;

         skillReadiness.SelectSkillTarget(selectSkillTarget);
      }

      #endregion
   }
}
