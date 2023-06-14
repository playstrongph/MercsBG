using UnityEngine;

public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; }
    IPlayer OtherPlayer { get; set; }
    IHeroes Heroes { get; }

    Canvas Canvas { get; }
}