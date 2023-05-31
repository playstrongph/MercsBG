using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface IUsedSkillHeroTarget
{
    IHeroFrames HeroFrames { get; }
    Image HeroFrame { get; }
    Image ArmorImage { get; }
    Image DamageImage { get; }
    Image CriticalDamageImage { get; }
    TextMeshProUGUI AttackText { get; }
    TextMeshProUGUI HealthText { get; }
    TextMeshProUGUI ArmorText { get; }
    TextMeshProUGUI NameText { get; }
    TextMeshProUGUI RaceText { get; }
    TextMeshProUGUI DamageText { get; }
    Transform Transform { get; }
}