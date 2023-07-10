using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSkills : MonoBehaviour, IInitializeSkills
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
      var allyTeamAsset = BattleSceneManager.BattleScene1SettingsAsset.AllyTeamHeroes.HeroAssets;
      var enemyTeamAsset = BattleSceneManager.BattleScene1SettingsAsset.EnemyTeamHeroes.HeroAssets;
      var mainPlayerHeroes = BattleSceneManager.MainPlayer.Heroes.PlayerHeroes;
      var enemyPlayerHeroes = BattleSceneManager.EnemyPlayer.Heroes.PlayerHeroes;

      for (int i = 0; i < allyTeamAsset.Count; i++)
      {
         var skillAssets = allyTeamAsset[i].SkillAssets;
         var heroSkills = mainPlayerHeroes[i].HeroSkills.AllSkills;
         
         

         for (int j = 0; j < skillAssets.Count; j++)
         {
            heroSkills[j].SkillAttributes.SkillName = skillAssets[j].SkillName;
            heroSkills[j].SkillAttributes.Description = skillAssets[j].SkillDescription;
            heroSkills[j].SkillAttributes.SkillCooldown = skillAssets[j].SkillCooldown;
            heroSkills[j].SkillAttributes.SkillSpeed = skillAssets[j].SkillSpeed;
            heroSkills[j].SkillAttributes.FightingSpirit = skillAssets[j].FightingSpirit;
            heroSkills[j].SkillAttributes.BaseSkillCooldown = skillAssets[j].SkillCooldown;
            heroSkills[j].SkillAttributes.BaseSkillSpeed = skillAssets[j].SkillSpeed;
            heroSkills[j].SkillAttributes.SkillSprite = skillAssets[j].SkillSprite;
            
            heroSkills[j].SkillAttributes.SkillElement = skillAssets[j].SkillElement;
            heroSkills[j].SkillAttributes.SkillType = skillAssets[j].SkillType;
            heroSkills[j].SkillAttributes.SkillTarget = skillAssets[j].SkillTarget;
            heroSkills[j].SkillAttributes.SkillReadiness = skillAssets[j].SkillReadiness;
            heroSkills[j].SkillAttributes.SkillEnableStatus = skillAssets[j].SkillEnableStatusAsset;
         }
         
         //Set the number of in use hero skills
         mainPlayerHeroes[i].HeroSkills.InUseHeroSkills = skillAssets.Count;
      }
      
      for (int i = 0; i < enemyTeamAsset.Count; i++)
      {
         var skillAssets = enemyTeamAsset[i].SkillAssets;
         var heroSkills = enemyPlayerHeroes[i].HeroSkills.AllSkills;

         for (int j = 0; j < skillAssets.Count; j++)
         {
            heroSkills[j].SkillAttributes.SkillName = skillAssets[j].SkillName;
            heroSkills[j].SkillAttributes.Description = skillAssets[j].SkillDescription;
            heroSkills[j].SkillAttributes.SkillCooldown = skillAssets[j].SkillCooldown;
            heroSkills[j].SkillAttributes.SkillSpeed = skillAssets[j].SkillSpeed;
            heroSkills[j].SkillAttributes.FightingSpirit = skillAssets[j].FightingSpirit;
            heroSkills[j].SkillAttributes.BaseSkillCooldown = skillAssets[j].SkillCooldown;
            heroSkills[j].SkillAttributes.BaseSkillSpeed = skillAssets[j].SkillSpeed;
            heroSkills[j].SkillAttributes.SkillSprite = skillAssets[j].SkillSprite;
            
            heroSkills[j].SkillAttributes.SkillElement = skillAssets[j].SkillElement;
            heroSkills[j].SkillAttributes.SkillType = skillAssets[j].SkillType;
            heroSkills[j].SkillAttributes.SkillTarget = skillAssets[j].SkillTarget;
            heroSkills[j].SkillAttributes.SkillReadiness = skillAssets[j].SkillReadiness;
            heroSkills[j].SkillAttributes.SkillEnableStatus = skillAssets[j].SkillEnableStatusAsset;
         }
         
         //Set the number of in use hero skills
         enemyPlayerHeroes[i].HeroSkills.InUseHeroSkills = skillAssets.Count;
      }
   }

   #endregion
}
