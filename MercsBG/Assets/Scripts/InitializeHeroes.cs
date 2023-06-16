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
      
      LoadHeroInformation();
      
      LoadHeroVisuals();
   }

   private void EnableHeroes()
   {
      var mainPlayerHeroes = BattleSceneManager.MainPlayer.Heroes.PlayerHeroes;
      var enemyPlayerHeroes = BattleSceneManager.EnemyPlayer.Heroes.PlayerHeroes;
      
      var battleSceneSettings = BattleSceneManager.BattleScene1SettingsAsset;
      var allyHeroes = battleSceneSettings.AllyTeamHeroes.HeroAssets;
      var enemyHeroes = battleSceneSettings.EnemyTeamHeroes.HeroAssets;
      
      
      //Enable main player heroes
      for (var i = 0; i < mainPlayerHeroes.Count; i++)
      {
         mainPlayerHeroes[i].ThisGameObject.SetActive(i < allyHeroes.Count);
      }
      
      //Enable enemy player heroes
      for (var i = 0; i < enemyPlayerHeroes.Count; i++)
      {
         enemyPlayerHeroes[i].ThisGameObject.SetActive(i < allyHeroes.Count);
      }
   }

   private void LoadHeroInformation()
   {
      var allyTeamAsset = BattleSceneManager.BattleScene1SettingsAsset.AllyTeamHeroes.HeroAssets;
      var enemyTeamAsset = BattleSceneManager.BattleScene1SettingsAsset.EnemyTeamHeroes.HeroAssets;
      var mainPlayerHeroes = BattleSceneManager.MainPlayer.Heroes.PlayerHeroes;
      var enemyPlayerHeroes = BattleSceneManager.EnemyPlayer.Heroes.PlayerHeroes;


      for (int i = 0; i < allyTeamAsset.Count; i++)
      {
         var heroInformation = mainPlayerHeroes[i].HeroInformation;
         var heroAsset = allyTeamAsset[i];

         heroInformation.HeroName = heroAsset.HeroName;
         heroInformation.HeroClass = heroAsset.HeroClass;

         mainPlayerHeroes[i].ThisGameObject.name = heroAsset.HeroName;
      }
      
      for (int i = 0; i < enemyTeamAsset.Count; i++)
      {
         var heroInformation = enemyPlayerHeroes[i].HeroInformation;
         var heroAsset = enemyTeamAsset[i];

         heroInformation.HeroName = heroAsset.HeroName;
         heroInformation.HeroClass = heroAsset.HeroClass;
         
         enemyPlayerHeroes[i].ThisGameObject.name = heroAsset.HeroName;
      }
      
   }



   private void LoadHeroVisuals()
   {
      var allyTeamAsset = BattleSceneManager.BattleScene1SettingsAsset.AllyTeamHeroes.HeroAssets;
      var enemyTeamAsset = BattleSceneManager.BattleScene1SettingsAsset.EnemyTeamHeroes.HeroAssets;
      var mainPlayerHeroes = BattleSceneManager.MainPlayer.Heroes.PlayerHeroes;
      var enemyPlayerHeroes = BattleSceneManager.EnemyPlayer.Heroes.PlayerHeroes;
      
      //Ally Heroes
      for (int i = 0; i < allyTeamAsset.Count; i++)
      {
         var heroVisual = mainPlayerHeroes[i].HeroVisual;
         var heroAsset = allyTeamAsset[i];
         
         //TODO - Images
         heroVisual.HeroGraphic.sprite = heroAsset.HeroSprite;
         heroAsset.HeroClass.SetClassColor(heroVisual.Hero);
         
         //TODO - TEXTs
         heroVisual.ArmorText.text = heroAsset.Armor.ToString();
         heroVisual.HealthText.text = heroAsset.Health.ToString();
         heroVisual.AttackText.text = heroAsset.Attack.ToString();
      }
      
      //Enemy Heroes
      for (int i = 0; i < enemyTeamAsset.Count; i++)
      {
         var heroVisual = enemyPlayerHeroes[i].HeroVisual;
         var heroAsset = enemyTeamAsset[i];
         
         //TODO - Images
         heroVisual.HeroGraphic.sprite = heroAsset.HeroSprite;
         heroAsset.HeroClass.SetClassColor(heroVisual.Hero);
         
         //TODO - TEXTs
         heroVisual.ArmorText.text = heroAsset.Armor.ToString();
         heroVisual.HealthText.text = heroAsset.Health.ToString();
         heroVisual.AttackText.text = heroAsset.Attack.ToString();
      }
      
      
      
   }

   #endregion
}
