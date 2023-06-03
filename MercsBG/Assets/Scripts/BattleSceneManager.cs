using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BattleSceneManager : MonoBehaviour, IBattleSceneManager
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoard))] private Object gameBoard = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object mainPlayer = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object enemyPlayer = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkills = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillsHistory))] private Object usedSkillsHistory = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ICombatButton))] private Object combatButton = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object displaySkillTargeting = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreview))] private Object heroPreview = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreview))] private Object skillPreview = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillPreview))] private Object usedSkillPreview = null;
  


   #endregion

   #region PROPERTIES
   
   public IGameBoard GameBoard => gameBoard as IGameBoard;
   public IPlayer MainPlayer => mainPlayer as IPlayer;
   public IPlayer EnemyPlayer => enemyPlayer as IPlayer;
   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkills as IHeroSkillsDisplay;
   public IUsedSkillsHistory UsedSkillsHistory => usedSkillsHistory as IUsedSkillsHistory;
   public ICombatButton CombatButton => combatButton as ICombatButton;
   public ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;
   
   public ISkillTargeting DisplaySkillTargeting => displaySkillTargeting as ISkillTargeting;

   public IHeroPreview HeroPreview => heroPreview as IHeroPreview;
   public ISkillPreview SkillPreview => skillPreview as ISkillPreview;
   public IUsedSkillPreview UsedSkillPreview => usedSkillPreview as IUsedSkillPreview;

   public Transform Transform => transform;
   




   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
