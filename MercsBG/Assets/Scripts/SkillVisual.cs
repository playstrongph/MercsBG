using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillVisual : MonoBehaviour, ISkillVisual
{
   #region VARIABLES
   
   [Header("Skill GameObjects")]
   [SerializeField] private GameObject skillReady = null;   
   [SerializeField] private GameObject skillNotReady = null;
   [SerializeField] private GameObject passiveSkill = null;
   
   [Header("Skill Images")]
   [SerializeField] private Image skillReadyGraphic = null;
   [SerializeField] private Image skillNotReadyGraphic = null;
   [SerializeField] private Image passiveSkillGraphic = null;

   [Header("Skill Text")] 
   [SerializeField] private TextMeshProUGUI speedText = null;
   [SerializeField] private TextMeshProUGUI cooldownText = null;
   
   [Header("Skill GameObjects")]
   [SerializeField] private Canvas skillReadyCanvas = null;   
   [SerializeField] private Canvas skillNotReadyCanvas = null;
   [SerializeField] private Canvas passiveSkillCanvas = null;
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetCollider))] private Object skillTargetCollider = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerSelectsSkill))] private Object playerSelectsSkill = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargets))] private Object skillTargets = null;
   
   [Header("Inspector References")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisuals))] private Object skillVisuals = null;

   #endregion

   #region PROPERTIES

   //GameObjects
   public GameObject SkillReady => skillReady;
   public GameObject SkillNotReady => skillNotReady;
   public GameObject PassiveSkill => passiveSkill;
   
   //Images
   public Image SkillReadyGraphic => skillReadyGraphic;
   public Image SkillNotReadyGraphic => skillNotReadyGraphic;
   public Image PassiveSkillGraphic => passiveSkillGraphic;
   
   //Texts
   public TextMeshProUGUI SpeedText => speedText;
   public TextMeshProUGUI CooldownText => cooldownText;
   
   //Canvas
   public Canvas SkillReadyCanvas => skillReadyCanvas;
   public Canvas SkillNotReadyCanvas => skillNotReadyCanvas;
   public Canvas PassiveSkillCanvas => passiveSkillCanvas;
   
   //Components
   public ISkillTargetCollider SkillTargetCollider => skillTargetCollider as ISkillTargetCollider;
   public IPlayerSelectsSkill PlayerSelectsSkill => playerSelectsSkill as IPlayerSelectsSkill;
   public ISkillTargets SkillTargets=> skillTargets as ISkillTargets;
   
   //Inspector References
   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkillsDisplay as IHeroSkillsDisplay;
   public ISkillVisuals SkillVisuals => skillVisuals as ISkillVisuals;
   
   //Reference to the skill
   public ISkill Skill { get; set; }
   
   
   //Others
   public Transform Transform
   {
      get => transform; 
      set => value = transform;
   }


   #endregion

   #region METHODS



   #endregion
}
