using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "SkillEnabled", menuName = "Assets/SkillEnableStatus/SkillEnabled")]
   public class SkillEnabledAsset : SkillEnableStatusAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         
        
      }
      
      
      /// <summary>
      /// Verification that skill is enabled before setting the valid target hero
      /// after mouse up in manual/auto select target scripts
      /// </summary>
      /// <param name="skill"></param>
      public override void SelectTarget(ISkill skill)
      {
         
      }

      public override void DisableTargetVisuals(ISkill skill)
      {
         
      }
      
      /// <summary>
      /// This is the "X" icon 
      /// </summary>
      /// <param name="skill"></param>
      public override void SkillDisabledVisuals(ISkill skill)
      {
         
      }
   
      /// <summary>
      /// Skill can only be selected if it is enabled
      /// </summary>
      /// <param name="skillTargetCollider"></param>
      public override void ManualSelectSkill(ISkillTargetCollider skillTargetCollider)
      {
         var skillReadiness = skillTargetCollider.SkillVisual.Skill.SkillAttributes.SkillReadiness;
         
         skillReadiness.ManualSelectSkill(skillTargetCollider);
         
      }
      
        

      #endregion
   }
}
