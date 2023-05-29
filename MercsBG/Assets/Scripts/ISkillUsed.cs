using TMPro;
using UnityEngine.UI;

public interface ISkillUsed
{
   
    ISkillPreviewFrames SkillPreviewFrames { get; }
    IHeroFrames HeroFrames { get; }
    Image SkillGraphic { get; }
    Image CooldownGraphic { get; }
    Image SpeedGraphic { get; }
    Image ArrowGraphic { get; }
    Image ArrowGlowGraphic { get; }
    Image HeroGraphic { get; }
    TextMeshProUGUI SkillNameText { get; }
    TextMeshProUGUI ElementText { get; }
    TextMeshProUGUI DescriptionText { get; }
    TextMeshProUGUI CooldownText { get; }
    TextMeshProUGUI SpeedText { get; }
}