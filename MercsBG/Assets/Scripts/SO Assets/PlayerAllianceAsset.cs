using UnityEngine;

namespace SO_Assets
{
   public class PlayerAllianceAsset : ScriptableObject, IPlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void UpdateHeroSkillsOnDisplay(IHeroSkills heroSkills, IPlayer player)
      {
         // 1) Disable the current hero skills on display
         // 2) Replace the current hero skills on display
         // 3) Enable the current hero skills on display
         // Note: Only for Ally player and its heroes.  No skill panel display for enemy player and ally heroes
      }  
      
      public virtual void DisplaySkillsAndScaleUpHero(IHero hero)
      {
         /*
         //Logic below is for ally heroes only 
         var newScale = new Vector3(1.5f, 1.5f, 1f);
         hero.HeroTransform.localScale = newScale;
         */
      }

      #endregion
   }
}
