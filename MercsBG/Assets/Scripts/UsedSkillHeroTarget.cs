using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class UsedSkillHeroTarget : MonoBehaviour, IUsedSkillHeroTarget
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroFrames))] private Object heroFrames = null;
   
   [Header("Used Skill Images")]
   [SerializeField] private Image heroFrame = null;
   [SerializeField] private Image armorImage = null;
   [SerializeField] private Image damageImage = null;
   [SerializeField] private Image criticalDamageImage = null;

   [Header("Used Skill Texts")] 
   [SerializeField] private TextMeshProUGUI attackText = null;
   [SerializeField] private TextMeshProUGUI healthText = null;
   [SerializeField] private TextMeshProUGUI armorText = null;
   [SerializeField] private TextMeshProUGUI nameText = null;
   [SerializeField] private TextMeshProUGUI raceText = null;
   [SerializeField] private TextMeshProUGUI damageText = null;
   


   #endregion

   #region PROPERTIES
   
   public IHeroFrames HeroFrames => heroFrames as IHeroFrames;

   public Image HeroFrame => heroFrame;
   public Image ArmorImage => armorImage;
   public Image DamageImage => damageImage;
   public Image CriticalDamageImage => criticalDamageImage;

   public TextMeshProUGUI AttackText => attackText;
   public TextMeshProUGUI HealthText => healthText;
   public TextMeshProUGUI ArmorText => armorText;
   public TextMeshProUGUI NameText => nameText;
   public TextMeshProUGUI RaceText => raceText;
   public TextMeshProUGUI DamageText => damageText;
   public Transform Transform => this.transform;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
