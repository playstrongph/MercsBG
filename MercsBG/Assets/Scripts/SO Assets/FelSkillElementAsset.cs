using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Fel", menuName = "Assets/SkillElement/FelElement")]
   public class FelSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "Fel";  

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
