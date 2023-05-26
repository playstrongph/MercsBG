using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillPreview : MonoBehaviour, ISkillPreview
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewFrames))] private Object skillPreviewFrames = null;
   
   [Header("Skill Preview Images")]
   [SerializeField] private Image skillGraphic = null;
   [SerializeField] private Image cooldownGraphic = null;
   [SerializeField] private Image speedGraphic = null;
   
   [Header("Skill Preview Text")]
   [SerializeField] private TextMeshProUGUI nameText = null;
   [SerializeField] private TextMeshProUGUI elementText = null;
   [SerializeField] private TextMeshProUGUI descriptionText = null;
   [SerializeField] private TextMeshProUGUI cooldownText = null;
   [SerializeField] private TextMeshProUGUI speedText = null;


   #endregion

   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public ISkillPreviewFrames SkillPreviewFrames => skillPreviewFrames as ISkillPreviewFrames;
   public Image SkillGraphic => skillGraphic;
   public Image CooldownGraphic => cooldownGraphic;
   public Image SpeedGraphic => speedGraphic;
   
   public TextMeshProUGUI NameText => nameText;
   public TextMeshProUGUI ElementText => elementText;
   public TextMeshProUGUI DescriptionText => descriptionText;
   public TextMeshProUGUI CooldownText => cooldownText;
   public TextMeshProUGUI SpeedText => speedText;
   
   
   

   #endregion

   #region METHODS



   #endregion
}
