using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "SkillReady", menuName = "Assets/SkillReadiness/SkillReady")]
   public class SkillReadyAsset : SkillReadinessAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override void LoadSkillReadinessVisuals(ISkill skill)
      {
         
      }
      
      /// <summary>
      /// Enable skill targeting when skill is NOT disabled and skill is ready
      /// </summary>
      /// <param name="transform"></param>
      /// <param name="skillTargetCollider"></param>
      public override void EnableTargetVisuals(Transform transform, ISkillTargetCollider skillTargetCollider)
      {
         //var skill = skillTargetCollider.Skill;
         //skill.SkillAttributes.SkillEnableStatus.EnableTargetVisuals(transform,skillTargetCollider);

      }
      
      /// <summary>
      /// Used in verifying if skill is ready and enabled
      /// </summary>
      /// <param name="skill"></param>
      public override void SelectTarget(ISkill skill)
      {
         
      }
      
      public override void DisableTargetVisuals(ISkill skill)
      {
         
      }
        
      /// <summary>
      /// Active and Basic skill select
      /// </summary>
      /// <param name="skillTargetCollider"></param>
      public override void ManualSelectSkill(ISkillTargetCollider skillTargetCollider)
      {
         skillTargetCollider.ManualSelectSkill();
      }

      #endregion
   }
}
