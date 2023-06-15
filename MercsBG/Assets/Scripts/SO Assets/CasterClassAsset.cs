using UnityEngine;

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
        

      #endregion
   }
}
