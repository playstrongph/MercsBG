using UnityEngine;

public interface IHeroSkillsDisplay
{

    Canvas Canvas { get; }
    IBattleSceneManager BattleSceneManager { get; }

    ISkillVisuals ThreeSkillVisuals { get; }

    ISkillVisuals FourSkillVisuals { get; }

    IShowSkillsDisplay ShowSkillsDisplay { get; }

    ISkillVisual SelectedSkillVisual { get; set; }

    ISkillTargeting SkillTargeting { get; }

}