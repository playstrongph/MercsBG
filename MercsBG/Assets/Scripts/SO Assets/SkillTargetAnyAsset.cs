using System.Collections.Generic;
using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "SkillTargetAny", menuName = "Assets/SkillTargetAsset/SkillTargetAny")]
   public class SkillTargetAnyAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override List<IHero> GetHeroTargets(IHero hero)
      {
         //Ally heroes
         //All Other ally heroes
         //enemy heroes
         //None (empty list)
         var allAliveHeroes = new List<IHero>();
         
         //Add all living enemies
         allAliveHeroes.AddRange( hero.Player.OtherPlayer.HeroesStatusList.AliveHeroesList);
         
         //Add all living allies
         allAliveHeroes.AddRange(hero.Player.HeroesStatusList.AliveHeroesList);
       
         return allAliveHeroes;
      }
      
      /// <summary>
      /// Glow color is dependent on enemy type: Ally or Enemy
      /// </summary>
      public override void ShowTargetsGlow(IHero hero)
      {
         //Set glow to red 
         hero.HeroVisual.HeroGlows.SetColorYellow();
         
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
