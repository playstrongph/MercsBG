using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Fire", menuName = "Assets/SkillElement/FireElement")]
   public class FireSkillElementAsset : SkillElementAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string ElementName { get; } = "Fire";  

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
