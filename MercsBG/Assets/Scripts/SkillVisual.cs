﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillVisual : MonoBehaviour, ISkillVisual
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;
   
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
   
   

   #endregion

   #region PROPERTIES
   
   
   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkillsDisplay as IHeroSkillsDisplay;
   
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
   ISkillTargetCollider SkillTargetCollider => skillTargetCollider as ISkillTargetCollider;
   
   //Reference to the skill
   public ISkill Skill { get; set; }


   #endregion

   #region METHODS



   #endregion
}
