using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface ISkillVisual
{
    ISkill Skill { get; }
    GameObject SkillReady { get; }
    GameObject SkillNotReady { get; }
    GameObject PassiveSkill { get; }
    Image SkillReadyGraphic { get; }
    Image SkillNotReadyGraphic { get; }
    Image PassiveSkillGraphic { get; }
    TextMeshProUGUI SpeedText { get; }
    TextMeshProUGUI CooldownText { get; }
}