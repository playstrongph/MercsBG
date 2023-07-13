using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class Skill : MonoBehaviour, ISkill
{
   #region VARIABLES
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkills))] private Object heroSkills = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillAttributes))] private Object skillAttributes = null;

   [Header("Inspector References")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object casterHero = null;
   

   #endregion

   #region PROPERTIES

   public ISkillAttributes SkillAttributes => skillAttributes  as ISkillAttributes;
   public IHeroSkills HeroSkills => heroSkills as IHeroSkills;

   public IHero CasterHero => casterHero as IHero;


   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
