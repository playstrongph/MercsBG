using TMPro;
using UnityEngine.UI;

public interface IHeroPreviewHero
{
    IHeroFrames HeroFrames { get; }
    Image FrameGraphic { get; }
    Image HeroGraphic { get; }
    Image ArmorGraphic { get; }
    TextMeshProUGUI AttackText { get; }
    TextMeshProUGUI HealthText { get; }
    TextMeshProUGUI ArmorText { get; }
    TextMeshProUGUI NameText { get; }
    TextMeshProUGUI RaceText { get; }
}