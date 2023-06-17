using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "NoElement", menuName = "Assets/SkillElement/NoElement")]
   public class NoSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "";  

      #endregion
        
      #region METHODS

      /// <summary>
      /// Set text of Skill Element in the skill preview
      /// </summary>
      /// <param name="skill"></param>
      public override void SetElement(ISkill skill)
      {
          
      }  

      #endregion
   }
}
