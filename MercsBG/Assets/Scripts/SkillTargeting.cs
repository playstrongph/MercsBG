using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargeting : MonoBehaviour, ISkillTargeting
{
   #region VARIABLES

   [Header("Components")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingCollider))] private Object skillTargetingCollider = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDraggable))] private Object draggable = null;

   #endregion

   #region PROPERTIES

   public ISkillTargetingCollider SkillTargetingCollider => skillTargetingCollider as ISkillTargetingCollider;
   public IDraggable Draggable => draggable as IDraggable;

   public Transform Transform => transform;

   #endregion

   #region METHODS



   #endregion
}
