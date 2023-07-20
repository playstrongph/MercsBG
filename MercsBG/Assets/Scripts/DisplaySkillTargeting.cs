using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySkillTargeting : MonoBehaviour, IDisplaySkillTargeting
{
   #region VARIABLES

   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingGameObjects))] private Object skillTargetingCollider = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IShowDisplayArrowLineAndCrossHair))] private Object showDisplayArrowLineAndCrossHair = null;


   [Header("Inspector References")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;
   
   [Header("Runtime")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;


   #endregion

   #region PROPERTIES
   
   //Components
   
   public ISkillTargetingGameObjects SkillTargetingGameObjects => skillTargetingCollider as ISkillTargetingGameObjects;
   public IShowDisplayArrowLineAndCrossHair ShowDisplayArrowLineAndCrossHair => showDisplayArrowLineAndCrossHair as IShowDisplayArrowLineAndCrossHair;


   //Inspector References
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   public ISkillVisual SkillVisual
   {
      get => skillVisual as ISkillVisual;
      private set => skillVisual = value as Object;
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
