using UnityEngine;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "AllyPlayer", menuName = "Assets/PlayerAlliance/AllyPlayer")]
   public class AllyPlayerAsset : PlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override void UpdateHeroSkillsOnDisplay(IHeroSkills heroSkills, IPlayer player)
      {
         // 1) Disable the current hero skills on display
         // 2) Replace the current hero skills on display
         // 3) Enable the current hero skills on display
         // Note: Only for Ally player and its heroes.  No skill panel display for enemy player and ally heroes
      }  
      
      public override void DisplaySkillsAndScaleUpHero(IHero hero)
      {
         var newScale = new Vector3(1.5f, 1.5f, 1f);
         var heroSkillsDisplay = hero.Player.BattleSceneManager.HeroSkillsDisplay;
         
         //Scale Up Hero
         hero.Transform.localScale = newScale;
         
         //DisplaySkills
         heroSkillsDisplay.ShowSkillsDisplay.DisplayOn(hero);
      }
        

      #endregion
   }
}
