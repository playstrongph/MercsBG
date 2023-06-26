using UnityEngine;
using UnityEngine.UI;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "CasterClass", menuName = "Assets/HeroClass/CasterClass")]
   public class CasterClassAsset : HeroClassAsset
   {
      
        
      #region METHODS
      
      public override void SetClassColor(IHero hero)
      {
         var heroFrameImage = hero.HeroVisual.HeroFrame;
         
         hero.HeroVisual.HeroFrames.SetColorBlueCaster(heroFrameImage);
      }
      
      public override void SetHeroPreviewFrameColor(IHeroPreview heroPreview)
      {
         var image = heroPreview.HeroPreviewHero.FrameGraphic;
         
         //TODO: Set the image reference in FrameGraphic
         heroPreview.HeroPreviewHero.HeroFrames.SetColorBlueCaster(image);

      }
      
     

      #endregion
   }
}
