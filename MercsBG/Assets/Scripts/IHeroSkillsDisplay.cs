using UnityEngine;

public interface IHeroSkillsDisplay
{

    Canvas Canvas { get; }
    IBattleSceneManager BattleSceneManager { get; }

    ISkillVisuals ThreeSkillVisuals { get; }

    ISkillVisuals FourSkillVisuals { get; }

   
}