﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPreview : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewHero))] private Object heroPreviewHero = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewSkill))] private List<Object> heroPreviewSkills = new List<Object>();
   
   




   #endregion

   #region PROPERTIES

   public IHeroPreviewHero HeroPreviewHero => heroPreviewHero as IHeroPreviewHero;

   public List<IHeroPreviewSkill> HeroPreviewSkills
   {
      get
      {
         var newHeroPreviewSkills = new List<IHeroPreviewSkill>();
         foreach (var heroPreviewSkill in heroPreviewSkills)
         {
            newHeroPreviewSkills.Add(heroPreviewSkill as IHeroPreviewSkill);
         }
         return newHeroPreviewSkills;
      }
   }

   #endregion

   #region METHODS



   #endregion
}
