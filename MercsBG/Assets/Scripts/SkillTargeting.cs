using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargeting : MonoBehaviour, ISkillTargeting
{
   #region VARIABLES

   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingCollider))] private Object skillTargetingCollider = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDraggable))] private Object draggable = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IShowLineAndCrossHair))] private Object showLineAndCrossHair = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargets))] private Object skillTargets = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerSelectsSkill))] private Object playerSelectsSkill = null;
   
   
   [Header("Inspector References")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;


   #endregion

   #region PROPERTIES
   
   //Components
   
   public ISkillTargetingCollider SkillTargetingCollider => skillTargetingCollider as ISkillTargetingCollider;
   public IDraggable Draggable => draggable as IDraggable;
   public IShowLineAndCrossHair ShowLineAndCrossHair => showLineAndCrossHair as IShowLineAndCrossHair;
   public ISkillTargets SkillTargets => skillTargets as ISkillTargets;
   public IPlayerSelectsSkill PlayerSelectsSkill => playerSelectsSkill as IPlayerSelectsSkill;
   
   //Inspector References
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   private ISkillVisual SkillVisual
   {
      get => skillVisual as ISkillVisual;
      set => skillVisual = value as Object;
   }

   //Generic Properties
   public Transform Transform => transform;

   #endregion

   #region METHODS

   public void SetSkillVisual(ISkillVisual skillVisual)
   {
      SkillVisual = skillVisual;
   }



   #endregion
}
