public interface ISkillTargetCollider
{

    void ManualSelectSkill();

    void DeselectSkill();

    ISkillVisual SkillVisual { get; }
}