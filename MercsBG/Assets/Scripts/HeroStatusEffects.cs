using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStatusEffects : MonoBehaviour, IHeroStatusEffects
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IStatusEffect))]private List<Object> statusEffects = new List<Object>();

   #endregion

   #region PROPERTIES

   public List<IStatusEffect> StatusEffects
   {
      get
      {
         var newStatusEffects = new List<IStatusEffect>();
         foreach (var statusEffect in statusEffects)
         {
            newStatusEffects.Add(statusEffect as IStatusEffect);
         }
         return newStatusEffects;
      }
   }


   #endregion

   #region METHODS



   #endregion
}
