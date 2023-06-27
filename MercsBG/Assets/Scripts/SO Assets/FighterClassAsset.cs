using UnityEngine;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "FighterClass", menuName = "Assets/HeroClass/FighterClass")]
   public class FighterClassAsset : HeroClassAsset
   {
      
        
      #region METHODS
      
      public override void SetClassColor(IHero hero)
      {
         hero.HeroVisual.HeroFrames.SetColorGreenFighter();
      }
      
      public override void SetHeroPreviewFrameColor(IHeroPreview heroPreview)
      {
         heroPreview.HeroPreviewHero.HeroFrames.SetColorGreenFighter();

      }
        

      #endregion
   }
}
