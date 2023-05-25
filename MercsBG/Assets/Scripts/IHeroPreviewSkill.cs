using TMPro;
using UnityEngine.UI;

public interface IHeroPreviewSkill
{
    ISkillPreviewFrames SkillPreviewFrames { get; }
    Image PreviewFrame { get; }
    Image SkillGraphic { get; }
    Image CooldownGraphic { get; }
    Image SpeedGraphic { get; }
    TextMeshProUGUI SkillNameText { get; }
    TextMeshProUGUI SkillElementText { get; }
    TextMeshProUGUI SkillDescriptionText { get; }
    TextMeshProUGUI SkillCooldownText { get; }
    TextMeshProUGUI SkillSpeedText { get; }
}