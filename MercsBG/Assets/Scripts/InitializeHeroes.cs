using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeHeroes : MonoBehaviour, IInitializeHeroes
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;

   #endregion

   #region PROPERTIES

   private IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   #endregion

   #region METHODS

   public void StartAction()
   {
      EnableHeroes();
   }

   private void EnableHeroes()
   {
      var mainPlayerHeroes = BattleSceneManager.MainPlayer.Heroes.PlayerHeroes;
      var enemyPlayerHeroes = BattleSceneManager.EnemyPlayer.Heroes.PlayerHeroes;
      
      var battleSceneSettings = BattleSceneManager.BattleScene1SettingsAsset;
      var allyHeroes = battleSceneSettings.AllyTeamHeroes.HeroAssets;
      var enemyHeroes = battleSceneSettings.EnemyTeamHeroes.HeroAssets;
      
      
      //Enable main player heroes
      for (int i = 0; i < mainPlayerHeroes.Count; i++)
      {
         if (i < allyHeroes.Count)
         {
           mainPlayerHeroes[i].ThisGameObject.SetActive(true);
         }
         else
         {
            mainPlayerHeroes[i].ThisGameObject.SetActive(false);
         }
      }
      
      //Enable enemy player heroes
      for (int i = 0; i < enemyPlayerHeroes.Count; i++)
      {
         if (i < allyHeroes.Count)
         {
            enemyPlayerHeroes[i].ThisGameObject.SetActive(true);
         }
         else
         {
            enemyPlayerHeroes[i].ThisGameObject.SetActive(false);
         }
      }
   }

   #endregion
}
