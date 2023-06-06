using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class Skill : MonoBehaviour, ISkill
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillAttributes))] private Object skillAttributes = null;

   #endregion

   #region PROPERTIES
   
  
   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkillsDisplay as IHeroSkillsDisplay;
   
   public ISkillAttributes SkillAttributes => skillAttributes  as ISkillAttributes;


   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
