using UnityEngine;
using UnityEngine.UI;

namespace SO_Assets
{
   /// <summary>
   /// Fighter - Green
   /// Caster - Blue
   /// Defender - Red
   /// </summary>
   public class HeroClassAsset : ScriptableObject, IHeroClassAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void SetClassColor(IHero hero)
      {
         

      }
      
      public virtual void SetHeroPreviewFrameColor(IHeroPreview heroPreview)
      {
         

      }
      
      
      public virtual void SetSkillPreviewFrameColor(ISkillPreviewFrames skillPreviewFrames)
      {
         

      }
      
      public virtual void SetSkillPanelFrameColor(ISkillPanelFrames skillPanelFrames)
      {
         

      }
      
      
      
      

      #endregion
   }
}
