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
      
     
      
      public override void DisplayHeroSkills(IHero hero)
      {
         var heroSkillsDisplay = hero.Player.BattleSceneManager.HeroSkillsDisplay;

         //DisplaySkills
         heroSkillsDisplay.ShowSkillsDisplay.DisplayOn(hero);
      }

      public override void ScaleDownHero(IHero hero)
      {
         var newScale = new Vector3(1f, 1f, 1f);
         
         //Scale Up Hero
         hero.Transform.localScale = newScale;
      }
      
      public override void ScaleUpHero(IHero hero)
      {
         var newScale = new Vector3(1.5f, 1.5f, 1f);
         
         //Scale Up Hero
         hero.Transform.localScale = newScale;
      }


      #endregion
   }
}
