using UnityEngine;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "DefenderClass", menuName = "Assets/HeroClass/DefenderClass")]
   public class DefenderClassAsset : HeroClassAsset
   {
      
        
      #region METHODS
      
      public override void SetClassColor(IHero hero)
      {
         var heroFrameImage = hero.HeroVisual.HeroFrame;
         
         hero.HeroVisual.HeroFrames.SetColorRedDefender(heroFrameImage);
      }
        

      #endregion
   }
}
