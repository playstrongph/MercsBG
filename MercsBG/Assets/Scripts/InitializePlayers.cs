using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayers : MonoBehaviour, IInitializePlayers
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;


   #endregion

   #region PROPERTIES

   private IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   #endregion

   #region METHODS

   public void StartAction()
   {
      var mainPlayer = BattleSceneManager.MainPlayer;
      var enemyPlayer = BattleSceneManager.EnemyPlayer;
      
      
      //Set References
      mainPlayer.OtherPlayer = enemyPlayer;
      enemyPlayer.OtherPlayer = mainPlayer;
      
      //Enable Player Canvas
      mainPlayer.Canvas.enabled = true;
      enemyPlayer.Canvas.enabled = true;
      
      //Set Player Alliance
      mainPlayer.PlayerAlliance = BattleSceneManager.BattleScene1SettingsAsset.AllyTeamHeroes.PlayerAlliance;
      enemyPlayer.PlayerAlliance = BattleSceneManager.BattleScene1SettingsAsset.EnemyTeamHeroes.PlayerAlliance;

   }

   #endregion
}
