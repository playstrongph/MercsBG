﻿using UnityEngine;
using UnityEngine.UI;

public interface IGameBoard
{
    Canvas Canvas { get; }
    Image BoardImage { get; }

    IBattleSceneManager BattleSceneManager { get; }

    IInitializeGameBoard InitializeGameBoard { get; }

    IGameBoardCollider GameBoardCollider { get; }

    IPlayer MainPlayer { get; set; }
   
    IPlayer EnemyPlayer { get; set; }
}