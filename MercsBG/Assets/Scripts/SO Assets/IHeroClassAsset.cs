using UnityEngine.UI;

namespace SO_Assets
{
    public interface IHeroClassAsset
    {
        void SetClassColor(IHero hero);

        void SetHeroPreviewFrameColor(IHeroPreview heroPreview);

        void SetSkillPreviewFrameColor(ISkillPreviewFrames skillPreviewFrames);

        void SetSkillPanelFrameColor(ISkillPanelFrames skillPanelFrames);
    }
}