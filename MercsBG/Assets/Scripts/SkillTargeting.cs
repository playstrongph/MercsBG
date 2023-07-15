﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargeting : MonoBehaviour, ISkillTargeting
{
   #region VARIABLES

   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingGameObjects))] private Object skillTargetingCollider = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDraggable))] private Object draggable = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IShowLineAndCrossHair))] private Object showLineAndCrossHair = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargets))] private Object skillTargets = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerSelectsSkill))] private Object playerSelectsSkill = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISelectSkillTarget))] private Object selectSkillTarget = null;
   
   
   
   [Header("Inspector References")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   
   [Header("Runtime")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;


   #endregion

   #region PROPERTIES
   
   //Components
   
   public ISkillTargetingGameObjects SkillTargetingGameObjects => skillTargetingCollider as ISkillTargetingGameObjects;
   public IDraggable Draggable => draggable as IDraggable;
   public IShowLineAndCrossHair ShowLineAndCrossHair => showLineAndCrossHair as IShowLineAndCrossHair;
   public ISkillTargets SkillTargets => skillTargets as ISkillTargets;
   public IPlayerSelectsSkill PlayerSelectsSkill => playerSelectsSkill as IPlayerSelectsSkill;
   public ISelectSkillTarget SelectSkillTarget => selectSkillTarget as ISelectSkillTarget;
   
   //Inspector References
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   public ISkillVisual SkillVisual
   {
      get => skillVisual as ISkillVisual;
      set => skillVisual = value as Object;
   }

   //Generic Properties
   public Transform Transform => transform;

   #endregion

   #region METHODS

   public void SetSkillVisualReference(ISkillVisual skillVisualReference)
   {
      SkillVisual = skillVisualReference;
   }



   #endregion
}
