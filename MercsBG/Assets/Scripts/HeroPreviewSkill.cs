using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroPreviewSkill : MonoBehaviour, IHeroPreviewSkill
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewFrames))] private Object skillPreviewFrames = null;

   [Header("Skill Preview Images")]
   [SerializeField] private Image previewFrame = null;
   [SerializeField] private Image skillGraphic = null;
   [SerializeField] private Image cooldownGraphic = null;
   [SerializeField] private Image speedGraphic = null;

   [Header("Skill Preview Texts")]
   [SerializeField] private TextMeshProUGUI skillNameText = null;
   [SerializeField] private TextMeshProUGUI skillElementText = null;
   [SerializeField] private TextMeshProUGUI skillDescriptionText = null;
   [SerializeField] private TextMeshProUGUI skillCooldownText = null;
   [SerializeField] private TextMeshProUGUI skillSpeedText = null;

   #endregion

   #region PROPERTIES
   public ISkillPreviewFrames SkillPreviewFrames => skillPreviewFrames as ISkillPreviewFrames;

   public Image PreviewFrame => previewFrame;
   public Image SkillGraphic => skillGraphic;
   public Image CooldownGraphic => cooldownGraphic;
   public Image SpeedGraphic => speedGraphic;

   public TextMeshProUGUI SkillNameText => skillNameText;
   public TextMeshProUGUI SkillElementText => skillElementText;
   public TextMeshProUGUI SkillDescriptionText => skillDescriptionText;
   public TextMeshProUGUI SkillCooldownText => skillCooldownText;
   public TextMeshProUGUI SkillSpeedText => skillSpeedText;


   #endregion

   #region METHODS



   #endregion
}
