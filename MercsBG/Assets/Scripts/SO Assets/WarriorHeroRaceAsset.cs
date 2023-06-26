using UnityEngine;

namespace SO_Assets
{  
   [CreateAssetMenu(fileName = "Warrior", menuName = "Assets/HeroRace/Warrior")]
   public class WarriorHeroRaceAsset : HeroRaceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

      public override string RaceName { get; } = "Warrior";  

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
