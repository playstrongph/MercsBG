using UnityEngine;

public interface IDisplaySkillTargeting
{
    
    //Components
    ISkillTargetingGameObjects SkillTargetingGameObjects { get; }
    IShowDisplayArrowLineAndCrossHair ShowDisplayArrowLineAndCrossHair { get; }
    Transform Transform { get; }
    
    //Inspector References
    IBattleSceneManager BattleSceneManager { get; }
    
    //Runtime
    ISkillVisual SkillVisual { get;}
    //Methods
    void SetSkillVisualReference(ISkillVisual skillVisualReference);
}