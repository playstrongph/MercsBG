using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Thief", menuName = "Assets/HeroRace/Thief")]
   public class ThiefHeroRaceAsset : HeroRaceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "Thief";  

      #endregion
        
      #region METHODS

      /// <summary>
      /// Set text of Skill Element in the skill preview
      /// </summary>
      /// <param name="hero"></param>
      public override void SetRace(IHero hero)
      {
          
      }  

      #endregion
   }
}
