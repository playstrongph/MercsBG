using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "ShadowElement", menuName = "Assets/SkillElement/ShadowElement")]
   public class ShadowSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "Shadow";  

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
