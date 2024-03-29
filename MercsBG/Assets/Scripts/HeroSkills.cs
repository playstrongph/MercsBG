﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HeroSkills : MonoBehaviour, IHeroSkills
{
   #region VARIABLES
   
   [Header("Inspector References")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object casterHero = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private List<Object> allSkills = new List<Object>();
   
   
   [Header("Runtime")]
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object selectedTargetHero = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private Object selectedCastingSkill = null;
   
   //TODO:TEST
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object selectedSkillVisual = null;
   
   //Current number of skills hero has, default is three
   [SerializeField] private int inUseHeroSkills = 3;
   
   

   #endregion

   #region PROPERTIES
   
   //Inspector References
   public IHero CasterHero => casterHero as IHero;

   public List<ISkill> AllSkills
   {
      get
      {
         var newSkills = new List<ISkill>();

         foreach (var skill in allSkills)
         {
            newSkills.Add(skill as ISkill);
         }
         
         return newSkills;
      }
   }
   
   //Runtime
   
   /// <summary>
   /// Used by display skill targeting
   /// </summary>
   public IHero SelectedTargetHero
   {
      get => selectedTargetHero as IHero;
      set => selectedTargetHero = value as Object;
   }
   /// <summary>
   /// Used by cancel selected skill
   /// </summary>
   public ISkill SelectedCastingSkill
   {
      get => selectedCastingSkill as ISkill;
      set => selectedCastingSkill = value as Object;
   }

   public ISkillVisual SelectedSkillVisual
   {
      get => selectedSkillVisual as ISkillVisual;
      private set => selectedSkillVisual = value as Object;
   }


   public int InUseHeroSkills { get=>inUseHeroSkills; set => inUseHeroSkills = value; }

   #endregion

   #region METHODS

   public void SetSelectedSkillVisual(ISkillVisual skillVisual)
   {
      SelectedSkillVisual = skillVisual;
   }


   #endregion
}
