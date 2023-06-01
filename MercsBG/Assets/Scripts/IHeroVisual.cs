using TMPro;
using UnityEngine.UI;

public interface IHeroVisual
{
    IHero Hero { get; }
    IHeroFrames HeroFrames { get; }
    IHeroGlows HeroGlows { get; }
    IHeroStatusEffects HeroStatusEffects { get; }
    Image HeroFrame { get; }
    Image HeroGraphic { get; }
    Image Armor { get; }
    Image TurnOrderBalloon { get; }
    TextMeshProUGUI AttackText { get; }
    TextMeshProUGUI HealthText { get; }
    TextMeshProUGUI ArmorText { get; }
    TextMeshProUGUI TurnOrderText { get; }
}