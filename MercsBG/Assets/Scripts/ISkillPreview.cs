using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface ISkillPreview
{
    IBattleSceneManager BattleSceneManager { get; }
    ISkillPreviewFrames SkillPreviewFrames { get; }
    Image SkillGraphic { get; }
    Image CooldownGraphic { get; }
    Image SpeedGraphic { get; }
    TextMeshProUGUI NameText { get; }
    TextMeshProUGUI ElementText { get; }
    TextMeshProUGUI DescriptionText { get; }
    TextMeshProUGUI CooldownText { get; }
    TextMeshProUGUI SpeedText { get; }

    Canvas Canvas { get; }
    
    //Components
    IShowSkillPreview ShowSkillPreview { get; }
}