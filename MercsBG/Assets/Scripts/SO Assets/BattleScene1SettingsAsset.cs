using System;
using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "BattleSceneSettings", menuName = "Assets/BattleSceneGeneral/BattleScene1Settings")]
   public class BattleScene1SettingsAsset : ScriptableObject, IBattleScene1SettingsAsset
   {
      #region VARIABLES

      [Header("SCRIPTABLE OBJECT ASSETS")]
      [SerializeField]  [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))] private ScriptableObject allyTeamHeroes; 
      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ITeamHeroesAsset))]private ScriptableObject enemyTeamHeroes;  

      #endregion
        
      #region PROPERTIES

      public ITeamHeroesAsset AllyTeamHeroes { get => allyTeamHeroes as ITeamHeroesAsset; private set => allyTeamHeroes = value as ScriptableObject; }
      public ITeamHeroesAsset EnemyTeamHeroes { get => enemyTeamHeroes as ITeamHeroesAsset; private set => enemyTeamHeroes = value as ScriptableObject; }  
      
      
      #endregion
        
      #region METHODS

      private void Awake()
      {
         
      }

      #endregion
   }
}
