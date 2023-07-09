using UnityEngine;

public interface ISkillTargeting
{
    ISkillTargetingCollider SkillTargetingCollider { get; }
    IDraggable Draggable { get; }
    Transform Transform { get; }
    IShowLineAndCrossHair ShowLineAndCrossHair { get; }

    IBattleSceneManager BattleSceneManager { get; }

}