using System.Collections.Generic;
using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "SkillTargetAlly", menuName = "Assets/SkillTargetAsset/SkillTargetAlly")]
   public class SkillTargetAllyAsset : SkillTargetAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS
      
      public override List<IHero> GetHeroTargets(IHero hero)
      {
         //Ally heroes
         return hero.Player.HeroesStatusList.AliveHeroesList;
      }
      
      /// <summary>
      /// Glow color is dependent on enemy type: Ally or Enemy
      /// </summary>
      public override void ShowTargetsGlow(IHero hero)
      {
         //Set glow to red 
         hero.HeroVisual.HeroGlows.SetColorGreen();
         
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
