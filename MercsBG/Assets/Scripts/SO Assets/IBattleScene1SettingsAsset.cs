namespace SO_Assets
{
    public interface IBattleScene1SettingsAsset
    {
        ITeamHeroesAsset AllyTeamHeroes { get; }
        ITeamHeroesAsset EnemyTeamHeroes { get; }
    }
}