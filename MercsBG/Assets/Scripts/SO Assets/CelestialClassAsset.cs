using UnityEngine;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "CelestialClass", menuName = "Assets/HeroClass/CelestialClass")]
   public class CelestialClassAsset : HeroClassAsset
   {
      
        
      #region METHODS
      
      public override void SetClassColor(IHero hero)
      {
         var heroFrameImage = hero.HeroVisual.HeroFrame;
         
         hero.HeroVisual.HeroFrames.SetColorGreenFighter(heroFrameImage);
      }
        

      #endregion
   }
}
