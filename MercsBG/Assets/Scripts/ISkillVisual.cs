using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface ISkillVisual
{
    
    GameObject SkillReady { get; }
    GameObject SkillNotReady { get; }
    GameObject PassiveSkill { get; }
    Image SkillReadyGraphic { get; }
    Image SkillNotReadyGraphic { get; }
    Image PassiveSkillGraphic { get; }
    TextMeshProUGUI SpeedText { get; }
    TextMeshProUGUI CooldownText { get; }

    Canvas SkillReadyCanvas { get; }
    Canvas SkillNotReadyCanvas { get; }
    Canvas PassiveSkillCanvas { get; }
    
    ISkill Skill { get; set; }

    IPlayerSelectsSkill PlayerSelectsSkill { get; }

    IHeroSkillsDisplay HeroSkillsDisplay { get; }

    ISkillTargetCollider SkillTargetCollider { get; }
    ISkillVisuals SkillVisuals { get; }

    ISkillTargets SkillTargets { get; }

    Transform Transform { get; set; }


}