using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class HeroSkillsDisplay : MonoBehaviour, IHeroSkillsDisplay
{
   #region VARIABLES

   [SerializeField] private Canvas canvas = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisuals))] private Object threeSkills = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisuals))] private Object fourSkills = null;

   [Header("COMPONENTS")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IShowSkillsDisplay))] private Object showSkillsDisplay = null;

   [Header("RUNTIME")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object selectedSkillVisual = null;
   
   #endregion

   #region PROPERTIES
   
   public Canvas Canvas => canvas;
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public ISkillVisuals ThreeSkillVisuals => threeSkills as ISkillVisuals;
   public ISkillVisuals FourSkillVisuals => fourSkills as ISkillVisuals;

   public ISkillVisual SelectedSkillVisual
   {
      get => selectedSkillVisual as ISkillVisual;
      set => selectedSkillVisual = value as Object;
   }

   //COMPONENTS
   public IShowSkillsDisplay ShowSkillsDisplay => showSkillsDisplay as IShowSkillsDisplay;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
