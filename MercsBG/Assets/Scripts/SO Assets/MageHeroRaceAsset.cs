using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Mage", menuName = "Assets/HeroRace/Mage")]
   public class MageHeroRaceAsset : HeroRaceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "Mage";  

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
