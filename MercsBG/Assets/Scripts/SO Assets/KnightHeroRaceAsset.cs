using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Knight", menuName = "Assets/HeroRace/Knight")]
   public class KnightHeroRaceAsset : HeroRaceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "Knight";  

      #endregion
        
      #region METHODS

      /// <summary>
      ///  Set text of Hero Race 
      /// </summary>
      /// <param name="hero"></param>
      public override void SetRace(IHero hero)
      {
          
      }  

      #endregion
   }
}
