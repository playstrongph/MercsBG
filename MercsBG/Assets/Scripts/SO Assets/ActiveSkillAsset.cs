using UnityEngine;

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

      #endregion
   }
}
