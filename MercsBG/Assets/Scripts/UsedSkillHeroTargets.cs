using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class UsedSkillHeroTargets : MonoBehaviour, IUsedSkillHeroTargets
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillHeroTarget))] private List<Object> heroTargets = new List<Object>();



   #endregion

   #region PROPERTIES

   public List<IUsedSkillHeroTarget> HeroTargets
   {
      get
      {
         var newHeroTargets = new List<IUsedSkillHeroTarget>();
         foreach (var heroTarget in heroTargets)
         {
            newHeroTargets.Add(heroTarget as IUsedSkillHeroTarget);
         }
         return newHeroTargets;
      }
   }

   public Transform Transform => this.transform;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   

   #endregion
}
