using UnityEngine;

public interface ISkillTargeting
{
    ISkillTargetingCollider SkillTargetingCollider { get; }
    IDraggable Draggable { get; }
    Transform Transform { get; }
}