using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "SkillDisabled", menuName = "Assets/SkillEnableStatus/SkillDisabled")]
   public class SkillDisabledAsset : SkillEnableStatusAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public override void EnableTargetVisuals(Transform transform, ISkillVisualCollider skillVisualCollider)
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
        

      #endregion
   }
}
