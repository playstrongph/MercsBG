using UnityEngine;

namespace SO_Assets
{
   public class HeroRaceAsset : ScriptableObject, IHeroRaceAsset
   {
    
        
      #region PROPERTIES

      public virtual string RaceName { get; } = "Hero Race";

      #endregion
        
      #region METHODS
      
      /// <summary>
      /// Set text of Hero Race in the hero preview
      /// </summary>
      /// <param name="hero"></param>
      public virtual void SetRace(IHero hero)
      {
          
      }
        

      #endregion
   }
}
