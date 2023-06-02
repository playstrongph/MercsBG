using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillVisual : MonoBehaviour, ISkillVisual
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private Object skill = null;   
   
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
   

   #endregion

   #region PROPERTIES

   public ISkill Skill => skill as ISkill;  
   
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


   #endregion

   #region METHODS



   #endregion
}
