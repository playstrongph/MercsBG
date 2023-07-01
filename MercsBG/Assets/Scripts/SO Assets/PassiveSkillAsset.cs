using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "PassiveSkill", menuName = "Assets/SkillType/PassiveSkill")]
   public class PassiveSkillAsset : SkillTypeAsset
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
      
      public override void SetSkillFrame(ISkillVisual skillVisual, int skillCooldown)
      {
         skillVisual.SkillReadyCanvas.enabled = false;
         skillVisual.SkillNotReadyCanvas.enabled = false;

         skillVisual.PassiveSkillCanvas.enabled = true;
      }
      
      public override void SetCooldownGraphicAndText(Image image, TextMeshProUGUI cooldownText ,int cooldown)
      {
         cooldownText.enabled = false;
         image.enabled = false;
      }
      
      public override void SetSpeedGraphicAndText(Image image, TextMeshProUGUI speedText, int speed)
      {
         speedText.enabled = false;
         image.enabled = false;
      }

      #endregion
   }
}
