using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAttributes : MonoBehaviour, ISkillAttributes
{
   #region VARIABLES
   
   [Header("Skill Information")]
   [Header("VALUES SET IN RUNTIME")]
   [SerializeField] private string skillName = null;
   
   [TextArea(5, 5)] [SerializeField] private string description = null;
   
   [Header("Skill Stats")] 
   [SerializeField] private int skillCooldown;
   [SerializeField] private int skillSpeed;
   [SerializeField] private int fightingSpirit = 0;
   
   [Header("Base Skill Stats")]
   [SerializeField] private int baseSkillCooldown;
   [SerializeField] private int baseSkillSpeed;

   [Header("Objects and Assets")]
   [SerializeField] private Sprite skillSprite = null;

   #endregion
        
   #region PROPERTIES
   
   public string SkillName { get => skillName; set => skillName = value; }
   public string Description { get => description; set => description = value; }
   public int SkillCooldown { get => skillCooldown; set => skillCooldown = value; }
   public int SkillSpeed { get => skillSpeed; set => skillSpeed = value; }
   
   public int FightingSpirit { get => fightingSpirit; set => fightingSpirit = value; }
   public int BaseSkillCooldown { get => baseSkillCooldown; set => baseSkillCooldown = value; }
   public int BaseSkillSpeed { get => baseSkillSpeed; set => baseSkillSpeed = value; }

   public Sprite SkillSprite { get => skillSprite; set => skillSprite = value; }
          

   #endregion
        
   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
