using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSkills : MonoBehaviour, IHeroSkills
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object hero = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private List<Object> allSkills = new List<Object>();


   #endregion

   #region PROPERTIES

   public IHero Hero => hero as IHero;

   public List<ISkill> AllSkills
   {
      get
      {
         var newSkills = new List<ISkill>();

         foreach (var skill in allSkills)
         {
            newSkills.Add(skill as ISkill);
         }
         
         return newSkills;
      }
   }


   #endregion

   #region METHODS



   #endregion
}
