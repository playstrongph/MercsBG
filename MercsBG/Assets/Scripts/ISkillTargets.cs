using System.Collections.Generic;

public interface ISkillTargets
{
    List<IHero> GetValidTargets();

    /// <summary>
    /// Clear valid Targets List
    /// </summary>
    void ClearValidTargets();

    /// <summary>
    /// Called by SkillTargetCollider On Mouse Down
    /// Color of glow determined by skill Target Type
    /// </summary>
    void ShowValidTargetsGlow();

    /// <summary>
    /// Called by SkillTargetCollider On Mouse Down
    /// Color of glow determined by skill Target Type
    /// </summary>
    void HideValidTargetsGlow();
}