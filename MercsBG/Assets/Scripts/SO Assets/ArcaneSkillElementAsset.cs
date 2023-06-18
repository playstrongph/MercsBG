using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Arcane", menuName = "Assets/SkillElement/ArcaneElement")]
   public class ArcaneSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "Arcane";  

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
