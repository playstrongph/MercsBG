using System.Collections.Generic;

public interface IUsedSkillsHistory
{
    IBattleSceneManager BattleSceneManager { get; }
    List<IUsedSkill> UsedSkills { get; }
}