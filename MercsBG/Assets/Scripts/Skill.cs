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

   #endregion

   #region PROPERTIES

   public ISkillAttributes SkillAttributes => skillAttributes  as ISkillAttributes;
   public IHeroSkills HeroSkills => heroSkills as IHeroSkills;


   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
