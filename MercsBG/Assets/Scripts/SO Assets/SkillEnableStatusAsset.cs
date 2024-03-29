﻿using UnityEngine;

namespace SO_Assets
{
   
   public class SkillEnableStatusAsset : ScriptableObject, ISkillEnableStatusAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void EnableTargetVisuals(Transform transform, ISkillVisualCollider skillVisualCollider)
      {
         
        
      }
      
      
      /// <summary>
      /// Verification that skill is enabled before setting the valid target hero
      /// after mouse up in manual/auto select target scripts
      /// </summary>
      /// <param name="skill"></param>
      public virtual void SelectTarget(ISkill skill)
      {
         
      }

      public virtual void DisableTargetVisuals(ISkill skill)
      {
         
      }
      
      /// <summary>
      /// This is the "X" icon 
      /// </summary>
      /// <param name="skill"></param>
      public virtual void SkillDisabledVisuals(ISkill skill)
      {
         
      }
      
      public virtual void ManualSelectSkill(ISkillVisualCollider skillVisualCollider)
      {
         
      }
      
      public virtual void SelectSkillTarget(ISelectSkillTarget selectSkillTarget)
      {
         
      }

      #endregion
   }
}
