using UnityEngine;

namespace SO_Assets
{
   
   [CreateAssetMenu(fileName = "DefenderClass", menuName = "Assets/HeroClass/DefenderClass")]
   public class DefenderClassAsset : HeroClassAsset
   {
      
        
      #region METHODS
      
      public override void SetClassColor(IHero hero)
      {
         hero.HeroVisual.HeroFrames.SetColorRedDefender();
      }
      
      
      public override void SetHeroPreviewFrameColor(IHeroPreview heroPreview)
      {
         heroPreview.HeroPreviewHero.HeroFrames.SetColorRedDefender();

      }
      
      public override void SetSkillPreviewFrameColor(ISkillPreviewFrames skillPreviewFrames)
      {
         skillPreviewFrames.SetColorRedDefender();
      }
      
      public override void SetSkillPanelFrameColor(ISkillPanelFrames skillPanelFrames)
      {
         skillPanelFrames.SetRedDefenderFrame();

      }
        

      #endregion
   }
}
