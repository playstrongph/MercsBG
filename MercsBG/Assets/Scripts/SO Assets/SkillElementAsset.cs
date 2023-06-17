using UnityEngine;

namespace SO_Assets
{
   public class SkillElementAsset : ScriptableObject, ISkillElementAsset
   {
    
        
      #region PROPERTIES

      public virtual string ElementName { get; } = "Skill Element";

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Set text of Hero Race in the hero preview
      /// </summary>
      /// <param name="skill"></param>
      public virtual void SetElement(ISkill skill)
      {
          
      }
        

      #endregion
   }
}
