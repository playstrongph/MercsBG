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
         hero.HeroVisual.HeroFrames.SetColorBlueCaster();
      }
      
      public override void SetHeroPreviewFrameColor(IHeroPreview heroPreview)
      {
         heroPreview.HeroPreviewHero.HeroFrames.SetColorBlueCaster();

      }
      
      public override void SetSkillPreviewFrameColor(ISkillPreviewFrames skillPreviewFrames)
      {
         skillPreviewFrames.SetColorBlueCaster();
      }
      
      
      
     

      #endregion
   }
}
