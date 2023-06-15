using UnityEngine;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "FighterClass", menuName = "Assets/HeroClass/FighterClass")]
   public class FighterClassAsset : HeroClassAsset
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
