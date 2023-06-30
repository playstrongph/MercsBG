using SO_Assets;
using UnityEngine;

public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; }
    IPlayer OtherPlayer { get; set; }
    IHeroes Heroes { get; }

    Canvas Canvas { get; }
    ISouls Souls { get; }

    IPlayerAllianceAsset PlayerAlliance { get; set; }

    IHero SelectedHero { get; set; }
}