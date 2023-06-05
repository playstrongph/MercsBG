using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class HeroSkillsDisplay : MonoBehaviour, IHeroSkillsDisplay
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisuals))] private Object threeSkills = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisuals))] private Object fourSkills = null;


   #endregion

   #region PROPERTIES
   
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public ISkillVisuals ThreeSkillVisuals => threeSkills as ISkillVisuals;
   public ISkillVisuals FourSkillVisuals => fourSkills as ISkillVisuals;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
