﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSkills : MonoBehaviour, IHeroSkills
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkills))] private Object threeSkills = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkills))] private Object fourSkills = null;


   #endregion

   #region PROPERTIES

   public ISkills ThreeSkills => threeSkills as ISkills;
   public ISkills FourSkills => fourSkills as ISkills;

   #endregion

   #region METHODS



   #endregion
}
