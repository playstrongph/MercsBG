using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class HeroVisual : MonoBehaviour, IHeroVisual
{
   #region VARIABLES

   [Header("HeroVisual Objects")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object hero = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFrames))] private Object heroFrames = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroGlows))] private Object heroGlows = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroStatusEffects))] private Object heroStatusEffects = null;

   [Header("HeroVisual Images")]
   
   [SerializeField] private Image heroFrame = null;
   [SerializeField] private Image heroGraphic = null;
   [SerializeField] private Image armor = null;
   [SerializeField] private Image turnOrderBalloon = null;

   [Header("HeroVisual Texts")] 
   [SerializeField] private TextMeshProUGUI attackText = null;
   [SerializeField] private TextMeshProUGUI healthText = null;
   [SerializeField] private TextMeshProUGUI armorText = null;
   [SerializeField] private TextMeshProUGUI turnOrderText = null;
   
   
   #endregion

   #region PROPERTIES
   
   //Objects
   public IHero Hero => hero as IHero;
   public IHeroFrames HeroFrames => heroFrames as IHeroFrames;
   public IHeroGlows HeroGlows => heroGlows as IHeroGlows;
   public IHeroStatusEffects HeroStatusEffects => heroStatusEffects as IHeroStatusEffects;
   
   //Images
   public Image HeroFrame => heroFrame;
   public Image HeroGraphic => heroGraphic;
   public Image Armor => armor;
   public Image TurnOrderBalloon => turnOrderBalloon;
   
   //Texts
   public TextMeshProUGUI AttackText => attackText;
   public TextMeshProUGUI HealthText => healthText;
   public TextMeshProUGUI ArmorText => armorText;
   public TextMeshProUGUI TurnOrderText => turnOrderText;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
