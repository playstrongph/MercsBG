using UnityEngine;

public interface ISkillTargeting
{
    //Components
    ISkillTargetingGameObjects SkillTargetingGameObjects { get; }
    IDraggable Draggable { get; }
    Transform Transform { get; }
    ISkillTargets SkillTargets { get; }
    IPlayerSelectsSkill PlayerSelectsSkill { get; }
    ISelectSkillTarget SelectSkillTarget { get; }
    IUnselectSkillAndTarget UnselectSkillAndTarget { get; }


    //Inspector References
    IBattleSceneManager BattleSceneManager { get; }
    
    //Runtime
    ISkillVisual SkillVisual { get; }
    
    //Public Methods
    IShowArrowLineAndCrossHair ShowArrowLineAndCrossHair { get; }
    void SetSkillVisualReference(ISkillVisual skillVisual);

}