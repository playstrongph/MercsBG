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
   
   
   [Header("Inspector References")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))] private Object battleSceneManager = null;


   #endregion

   #region PROPERTIES
   
   //Components
   public ISkillTargetingCollider SkillTargetingCollider => skillTargetingCollider as ISkillTargetingCollider;
   public IDraggable Draggable => draggable as IDraggable;
   public IShowLineAndCrossHair ShowLineAndCrossHair => showLineAndCrossHair as IShowLineAndCrossHair;
   
   //Inspector References
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   
   //Generic Properties
   public Transform Transform => transform;

   #endregion

   #region METHODS
   
   
   

   #endregion
}
