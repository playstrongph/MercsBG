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
      
      public override void SetSkillPreviewFrameColor(ISkillPreviewFrames skillPreviewFrames)
      {
         skillPreviewFrames.SetColorGreenFighter();
      }
      
      public override void SetSkillPanelFrameColor(ISkillPanelFrames skillPanelFrames)
      {
         skillPanelFrames.SetGreenFighterFrame();

      }
        

      #endregion
   }
}
