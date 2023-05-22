using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;


   #endregion

   #region PROPERTIES

   public ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;


   #endregion

   #region METHODS



   #endregion
}
