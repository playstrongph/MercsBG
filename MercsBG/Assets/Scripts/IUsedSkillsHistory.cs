using System.Collections.Generic;
using UnityEngine;

public interface IUsedSkillsHistory
{
    IBattleSceneManager BattleSceneManager { get; }
    List<IUsedSkill> UsedSkills { get; }
    Canvas Canvas { get; }

}