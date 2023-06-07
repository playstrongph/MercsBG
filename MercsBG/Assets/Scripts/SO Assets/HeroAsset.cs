using System;
using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "NewHero", menuName = "Assets/NewHero")]
   public class HeroAsset : ScriptableObject, IHeroAsset
   {
      #region VARIABLES
      
      [Header("Hero Attributes")]
      [SerializeField] private string heroName;
      [SerializeField] private int heroLevel;
      [SerializeField] private int heroStars;
      [SerializeField] private int heroCp;
      [SerializeField] private Sprite heroSprite;
      
      [Header("Base Hero Stats")] 
      [SerializeField] private int health;
      [SerializeField] private int attack;
      [SerializeField] private int defense;
      [SerializeField] private int speed;
      [SerializeField] private int armor = 0;
      [SerializeField] private int focusPoints = 0;
      
      
      [SerializeField] private int criticalHitChance = 50;
      [SerializeField] private int criticalHitDamage = 150;
      [SerializeField] private int effectiveness = 0;
      [SerializeField] private int effectResistance = 0;
      [SerializeField] private int dualAttackChance = 5;
      [SerializeField] private int hitChance = 100;
        

      #endregion
        
      #region PROPERTIES
      
      //Hero Attributes
      public string HeroName { get => heroName; private set => heroName = value; }
      public int HeroLevel { get => heroLevel; private set => heroLevel = value; }
      public int HeroStars { get => heroStars; private set => heroStars = value; }
      public int HeroCp { get => heroCp; private set => heroCp = value; }
      public Sprite HeroSprite { get => heroSprite; private set => heroSprite = value; }
      
      //Hero Stats
      public int Health { get => health; private set => health = value; }
      public int Attack { get => attack; private set => attack = value; }
      public int Defense { get => defense; private set => defense = value; }
      public int Speed { get => speed; private set => speed = value; }
      public int Armor { get => armor; private set => armor = value; }
      public int FocusPoints { get => focusPoints; private set => focusPoints = value; }
      
      
      public int CriticalHitChance { get => criticalHitChance; private set => criticalHitChance = value; }
      public int CriticalHitDamage { get => criticalHitDamage; private set => criticalHitDamage = value; }
      public int Effectiveness { get => effectiveness; private set => effectiveness = value; }
      public int EffectResistance { get => effectResistance; private set => effectResistance = value; }
      public int DualAttackChance { get => dualAttackChance; private set => dualAttackChance = value; }
      public int HitChance { get => hitChance; private set => hitChance = value; }

      #endregion
        
      #region METHODS

      private void Awake()
      {
         
      }
      
      #endregion
   }
}
