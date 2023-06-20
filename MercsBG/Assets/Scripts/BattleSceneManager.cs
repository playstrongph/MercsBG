using SO_Assets;
using UnityEngine;
using Object = UnityEngine.Object;

public class BattleSceneManager : MonoBehaviour, IBattleSceneManager
{
   #region VARIABLES

   [Header("GAME OBJECT REFERENCES")]

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleScene1SettingsAsset))] private Object battleScene1Settings = null;
   
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

   [Header("COMPONENTS")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleStart))] private Object battleStart = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializePlayers))] private Object initializePlayers = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeHeroes))] private Object initializeHeroes = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeSkills))] private Object initializeSkills = null;

   #endregion

   #region PROPERTIES
   
   private IBattleStart BattleStart => battleStart as IBattleStart;
   public IBattleScene1SettingsAsset BattleScene1SettingsAsset => battleScene1Settings as IBattleScene1SettingsAsset;
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
   
   public IInitializePlayers InitializePlayers => initializePlayers as IInitializePlayers;
   
   public IInitializeHeroes InitializeHeroes => initializeHeroes as IInitializeHeroes;
   
   public IInitializeSkills InitializeSkills => initializeSkills as IInitializeSkills;

   #endregion

   #region METHODS

   private void Start()
   {
      BattleStart.StartAction();
   }

   #endregion
}
