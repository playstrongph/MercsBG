using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour, ISkills
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkill))] private List<Object> heroSkills = new List<Object>();

   #endregion

   #region PROPERTIES

   public List<ISkill> HeroSkills
   {
      get
      {
         var newSkills = new List<ISkill>();
         {
            foreach (var heroSkill in heroSkills)
            {
               newSkills.Add(heroSkill as ISkill);
            }
         }
         return newSkills;
      }
   }

   #endregion

   #region METHODS



   #endregion
}
