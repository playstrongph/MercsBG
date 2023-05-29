using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class SkillUsed : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreviewFrames))] private Object skillPreviewFrames = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFrames))] private Object heroFrames = null;
   
   [Header("Image Components")]
   [SerializeField] private Image skillGraphic = null;
   [SerializeField] private Image cooldownGraphic = null;
   [SerializeField] private Image speedGraphic = null;
   [SerializeField] private Image arrowGraphic = null;
   [SerializeField] private Image arrowGlowGraphic = null;
   [SerializeField] private Image heroGraphic = null;
   
   [FormerlySerializedAs("skillName")]
   [Header("Text Components")]
   [SerializeField] private TextMeshProUGUI skillNameText = null;
   [SerializeField]private TextMeshProUGUI elementText = null;
   [SerializeField] private TextMeshProUGUI descriptionText = null;
   [SerializeField] private TextMeshProUGUI cooldownText = null;
   [SerializeField] private TextMeshProUGUI speedText = null;
   


   #endregion

   #region PROPERTIES

   public ISkillPreviewFrames SkillPreviewFrames => skillPreviewFrames as ISkillPreviewFrames;
   public IHeroFrames HeroFrames => heroFrames as IHeroFrames;
   
   //Images
   public Image SkillGraphic => skillGraphic;
   public Image CooldownGraphic => cooldownGraphic;
   public Image SpeedGraphic => speedGraphic;
   public Image ArrowGraphic => arrowGraphic;
   public Image ArrowGlowGraphic => arrowGlowGraphic;
   public Image HeroGraphic => heroGraphic;
   
   
   //Texts
   public TextMeshProUGUI SkillNameText => skillNameText;
   public TextMeshProUGUI ElementText => elementText;
   public TextMeshProUGUI DescriptionText => descriptionText;
   public TextMeshProUGUI CooldownText => cooldownText;
   public TextMeshProUGUI SpeedText => speedText;
   

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
