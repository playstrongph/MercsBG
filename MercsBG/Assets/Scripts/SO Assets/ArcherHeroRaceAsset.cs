using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Archer", menuName = "Assets/HeroRace/Archer")]
   public class ArcherHeroRaceAsset : HeroRaceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "Archer";  

      #endregion
        
      #region METHODS

      /// <summary>
      /// Set text of Hero Race 
      /// </summary>
      /// <param name="hero"></param>
      public override void SetRace(IHero hero)
      {
          
      }  

      #endregion
   }
}
