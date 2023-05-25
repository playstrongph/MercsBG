﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour, IBattleSceneManager
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoard))] private Object gameBoard = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object mainPlayer = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object enemyPlayer = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkills))] private Object heroSkills = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillsHistory))] private Object usedSkillsHistory = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ICombatButton))] private Object combatButton = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object displaySkillTargeting = null;


   #endregion

   #region PROPERTIES
   
   public IGameBoard GameBoard => gameBoard as IGameBoard;
   public IPlayer MainPlayer => mainPlayer as IPlayer;
   public IPlayer EnemyPlayer => enemyPlayer as IPlayer;
   public IHeroSkills HeroSkills => heroSkills as IHeroSkills;
   public IUsedSkillsHistory UsedSkillsHistory => usedSkillsHistory as IUsedSkillsHistory;
   public ICombatButton CombatButton => combatButton as ICombatButton;
   public ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;
   
   public ISkillTargeting DisplaySkillTargeting => displaySkillTargeting as ISkillTargeting;

   
   
   
   #endregion

   #region METHODS



   #endregion
}