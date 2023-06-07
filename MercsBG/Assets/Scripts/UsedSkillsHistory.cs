using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class UsedSkillsHistory : MonoBehaviour, IUsedSkillsHistory
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   [SerializeField] private Canvas canvas = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkill))] private List<Object> usedSkills = new List<Object>();

   
   
   #endregion

   #region PROPERTIES
   
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public List<IUsedSkill> UsedSkills
   {
      get
      {
         var newUsedSkills = new List<IUsedSkill>();
         foreach (var usedSkill in usedSkills)
         {
           newUsedSkills.Add(usedSkill as IUsedSkill);  
         }
         return newUsedSkills;
      }
   }

   public Canvas Canvas => canvas;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
