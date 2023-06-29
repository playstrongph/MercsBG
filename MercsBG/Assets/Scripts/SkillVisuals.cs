using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillVisuals : MonoBehaviour, ISkillVisuals
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private List<Object> heroSkillVisuals = new List<Object>();

   #endregion

   #region PROPERTIES

   public List<ISkillVisual> HeroSkillVisuals
   {
      get
      {
         var newHeroSkillVisuals = new List<ISkillVisual>();
         {
            foreach (var heroSkillVisual in heroSkillVisuals)
            {
               newHeroSkillVisuals.Add(heroSkillVisual as ISkillVisual);
            }
         }
         return newHeroSkillVisuals;
      }
   }


   public Transform Transform => transform;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
