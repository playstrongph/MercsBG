public interface IBattleSceneManager
{
    IGameBoard GameBoard { get; }
    IPlayer MainPlayer { get; }
    IPlayer EnemyPlayer { get; }
    IHeroSkills HeroSkills { get; }

    IUsedSkillsHistory UsedSkillsHistory { get; }


    ISkillTargeting SkillTargeting { get; }
}