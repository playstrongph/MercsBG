using UnityEngine;

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

      #endregion
   }
}
