using UnityEngine;

public interface ISkillTargeting
{
    ISkillTargetingCollider SkillTargetingCollider { get; }
    IDraggable Draggable { get; }
    Transform Transform { get; }

    ISkillTargets SkillTargets { get; }
    IPlayerSelectsSkill PlayerSelectsSkill { get; }


    IShowLineAndCrossHair ShowLineAndCrossHair { get; }

    IBattleSceneManager BattleSceneManager { get; }

    ISkillVisual SkillVisual { get; set; }

}