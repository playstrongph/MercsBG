public interface IUsedSkillPreview
{
    IBattleSceneManager BattleSceneManager { get; }
    IUsedSkillHeroTarget SingleHeroTarget { get; }
    IUsedSkillHeroTargets MultiHeroTargets { get; }
    ISkillUsed SkillUsed { get; }
}