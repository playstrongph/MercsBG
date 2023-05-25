public interface IBattleSceneManager
{
    IGameBoard GameBoard { get; }
    IPlayer MainPlayer { get; }
    IPlayer EnemyPlayer { get; }
    IHeroSkills HeroSkills { get; }
    IUsedSkillsHistory UsedSkillsHistory { get; }
    ICombatButton CombatButton { get; }
    ISkillTargeting SkillTargeting { get; }

    ISkillTargeting DisplaySkillTargeting { get; }
}