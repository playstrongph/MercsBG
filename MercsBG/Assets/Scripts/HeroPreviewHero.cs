using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class HeroPreviewHero : MonoBehaviour, IHeroPreviewHero
{
   #region VARIABLES
   
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFrames))]private Object heroFrames = null;
   
   [Header("Hero Preview Images")]
   [SerializeField] private Image frameGraphic = null;
   [SerializeField] private Image heroGraphic = null;
   [SerializeField] private Image armorGraphic = null;
   
   [Header("Hero Preview Text")]
   [SerializeField] private TextMeshProUGUI attackText = null;
   [SerializeField] private TextMeshProUGUI healthText = null;
   [SerializeField] private TextMeshProUGUI armorText = null;
   [SerializeField] private TextMeshProUGUI nameText = null;
   [SerializeField] private TextMeshProUGUI raceText = null; 


   #endregion

   #region PROPERTIES

   public IHeroFrames HeroFrames => heroFrames as IHeroFrames;

   public Image FrameGraphic => frameGraphic;
   public Image HeroGraphic => heroGraphic;
   public Image ArmorGraphic => armorGraphic;

   public TextMeshProUGUI AttackText => attackText;
   public TextMeshProUGUI HealthText => healthText;
   public TextMeshProUGUI ArmorText => armorText;
   public TextMeshProUGUI NameText => nameText;
   public TextMeshProUGUI RaceText => raceText;


   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
