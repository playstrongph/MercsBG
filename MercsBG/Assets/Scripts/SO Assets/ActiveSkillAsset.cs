using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "ActiveSkill", menuName = "Assets/SkillType/ActiveSkill")]
   public class ActiveSkillAsset : SkillTypeAsset
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

         skillVisual.PassiveSkillCanvas.enabled = false;
         
         //TODO: Replace this with skill readiness logic?
         if (skillCooldown <=0)
         {
            skillVisual.SkillReadyCanvas.enabled = true;
            skillVisual.SkillNotReadyCanvas.enabled = false;
          
         }
         else
         {
            skillVisual.SkillReadyCanvas.enabled = false;
            skillVisual.SkillNotReadyCanvas.enabled = true;   
         }
      }
      
      public override void SetCooldownGraphicAndText(Image image, TextMeshProUGUI cooldownText ,int cooldown)
      {
         if (cooldown <= 0)
         {
            cooldownText.enabled = false;
            image.enabled = false;
         }
         else
         {
            cooldownText.enabled = true;
            image.enabled = true;

            cooldownText.text = cooldown.ToString();
         }
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
      
      public override void ManualSelectSkill(ISkillTargetCollider skillTargetCollider)
      {
         var skillEnabledStatus = skillTargetCollider.SkillVisual.Skill.SkillAttributes.SkillEnableStatusAsset;
         
         skillEnabledStatus.ManualSelectSkill(skillTargetCollider);
      }

      #endregion
   }
}
