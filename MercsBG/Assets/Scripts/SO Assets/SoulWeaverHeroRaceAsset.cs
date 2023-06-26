using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "SoulWeaver", menuName = "Assets/HeroRace/SoulWeaver")]
   public class SoulWeaverHeroRaceAsset : HeroRaceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "SoulWeaver";  

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
