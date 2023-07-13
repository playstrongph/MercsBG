﻿using System.Collections.Generic;
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
         //Ally heroes
         //All Other ally heroes
         //enemy heroes
         //None (empty list)

         var enemyHeroes = hero.Player.OtherPlayer.HeroesStatusList.AliveHeroesList;

         return new List<IHero>();
      }
      
      /// <summary>
      /// Glow color is dependent on enemy type: Ally or Enemy
      /// </summary>
      public override void ShowTargetsGlow(IHero hero)
      {
         
      }
      
      /// <summary>
      /// Glow to be hidden is dependent on glow color that was shown
      /// </summary>
      public override void HideTargetsGlow(IHero hero)
      {
         
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
