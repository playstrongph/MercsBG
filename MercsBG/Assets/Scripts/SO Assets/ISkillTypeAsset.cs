namespace SO_Assets
{
    public interface ISkillTypeAsset
    {
        void LoadSkillTypeVisuals(ISkill skill);
        void SelectTarget(ISkill skill);
        void DisableTargetVisuals(ISkill skill);
        void EnableSkillTargeting(ISkill skill);
        void SetSkillFrame(ISkillVisual skillVisual, int skillCooldown);
    }
}