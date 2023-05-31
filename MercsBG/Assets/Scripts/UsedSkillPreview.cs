using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class UsedSkillPreview : MonoBehaviour, IUsedSkillPreview
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillHeroTarget))] private Object singleHeroTarget = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IUsedSkillHeroTargets))] private Object multiHeroTargets = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillUsed))] private Object skillUsed = null;

   #endregion

   #region PROPERTIES
   
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public IUsedSkillHeroTarget SingleHeroTarget => singleHeroTarget as IUsedSkillHeroTarget;
   public IUsedSkillHeroTargets MultiHeroTargets => multiHeroTargets as IUsedSkillHeroTargets;
   public ISkillUsed SkillUsed => skillUsed as ISkillUsed;
   
   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
