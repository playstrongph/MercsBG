using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class Skill : MonoBehaviour, ISkill
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkills))] private Object heroSkills = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;


   #endregion

   #region PROPERTIES
   
   public IHeroSkills HeroSkills => heroSkills as IHeroSkills;
   public ISkillVisual SkillVisual => skillVisual as ISkillVisual;


   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
