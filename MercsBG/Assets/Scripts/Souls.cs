using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souls : MonoBehaviour, ISouls
{
   #region VARIABLES

   [SerializeField] private int soulCount = 0;

   #endregion

   #region PROPERTIES

   public int SoulCount { get => soulCount; set => soulCount = value; }

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
