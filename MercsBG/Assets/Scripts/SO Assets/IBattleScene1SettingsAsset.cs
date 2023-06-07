using UnityEngine;

namespace SO_Assets
{
    public interface IBattleScene1SettingsAsset
    {
        ITeamHeroesAsset AllyTeamHeroes { get; }
        ITeamHeroesAsset EnemyTeamHeroes { get; }
        Sprite BoardImage { get; }
    }
}