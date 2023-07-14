using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SO_Assets
{
   public class SkillTypeAsset : ScriptableObject, ISkillTypeAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public virtual void LoadSkillTypeVisuals(ISkill skill)
      {
         
      }
      
      public virtual void SelectTarget(ISkill skill)
      {
         
      }


      public virtual void DisableTargetVisuals(ISkill skill)
      {
         
      }

      public virtual void EnableSkillTargeting(ISkill skill)
      {
         
      }

      public virtual void SetSkillFrame(ISkillVisual skillVisual, int skillCooldown)
      {
         
      }

      public virtual void SetCooldownGraphicAndText(Image image, TextMeshProUGUI cooldownText, int cooldown)
      {
         
      }
      
      public virtual void SetSpeedGraphicAndText(Image image, TextMeshProUGUI speedText, int speed)
      {
         
      }
      
      public virtual void SelectSkillActions(ISkillTargetCollider skillTargetCollider)
      {
         
      }
      
      


      #endregion
   }
}
