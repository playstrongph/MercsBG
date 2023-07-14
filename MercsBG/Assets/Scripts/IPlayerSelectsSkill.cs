public interface IPlayerSelectsSkill
{
    /// <summary>
    /// Select skill actions after status checks
    /// </summary>
    void SelectedSkillChecks();

    void DeselectSkillActions();

    /// <summary>
    /// Selects the skill if the following criteria are met:
    /// 1) Basic or Active Skill 2) Enabled Skill 3) Skill is Ready (cooldown)
    /// </summary>
    void SelectSkillActions();
}