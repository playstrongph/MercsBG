using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "ElementalElement", menuName = "Assets/SkillElement/ElementalElement")]
   public class ElementalSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "Elemental";  

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
