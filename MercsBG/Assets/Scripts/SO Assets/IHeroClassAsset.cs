using UnityEngine.UI;

namespace SO_Assets
{
    public interface IHeroClassAsset
    {
        void SetClassColor(IHero hero);

        void SetHeroPreviewFrameColor(IHeroPreview heroPreview);
    }
}