using UnityEngine;

public interface IDisplaySkillTargeting
{
    IDraggable Draggable { get; }
    IShowArrowLineAndCrossHair ShowArrowLineAndCrossHair { get; }
    ISkillTargets SkillTargets { get; }
    IPlayerSelectsSkill PlayerSelectsSkill { get; }
    ISelectSkillTarget SelectSkillTarget { get; }
    IBattleSceneManager BattleSceneManager { get; }
    ISkillVisual SkillVisual { get; set; }
    ISkillTargetingGameObjects SkillTargetingGameObjects { get; }
    Transform Transform { get; }
    void SetSkillVisualReference(ISkillVisual skillVisualReference);
}