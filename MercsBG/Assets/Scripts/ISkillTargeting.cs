using UnityEngine;

public interface ISkillTargeting
{
    ISkillTargetingGameObjects SkillTargetingGameObjects { get; }
    IDraggable Draggable { get; }
    Transform Transform { get; }

    ISkillTargets SkillTargets { get; }
    IPlayerSelectsSkill PlayerSelectsSkill { get; }


    IShowLineAndCrossHair ShowLineAndCrossHair { get; }

    IBattleSceneManager BattleSceneManager { get; }

    ISkillVisual SkillVisual { get; }
    void SetSkillVisualReference(ISkillVisual skillVisual);

}