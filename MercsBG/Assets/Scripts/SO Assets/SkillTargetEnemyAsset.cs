using System.Collections.Generic;
using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "SkillTargetEnemy", menuName = "Assets/SkillTargetAsset/SkillTargetEnemy")]
   public class SkillTargetEnemyAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override List<IHero> GetHeroTargets(IHero hero)
      {
         //Enemy Heroes
         return hero.Player.OtherPlayer.HeroesStatusList.AliveHeroesList;
      }
      
      /// <summary>
      /// Glow color is dependent on enemy type: Ally or Enemy
      /// </summary>
      public override void ShowTargetsGlow(IHero hero)
      {
         //Set glow to red 
         hero.HeroVisual.HeroGlows.SetColorRed();
         
         //show hero glow
         hero.HeroVisual.HeroGlows.ShowHeroGlow();
         
      }
      
      /// <summary>
      /// Glow to be hidden is dependent on glow color that was shown
      /// </summary>
      public override void HideTargetsGlow(IHero hero)
      {
         //hide hero glow
         hero.HeroVisual.HeroGlows.HideHeroGlow();
      }

      /// <summary>
      /// Resolve special circumstances in targeting
      /// </summary>
      /// <param name="hero"></param>
      public override void ResolveSpecialTargets(IHero hero)
      {
         //Example: Stealth and Taunt
      }
        

      #endregion
   }
}
