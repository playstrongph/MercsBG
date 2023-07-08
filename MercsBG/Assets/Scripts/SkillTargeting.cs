using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargeting : MonoBehaviour, ISkillTargeting
{
   #region VARIABLES

   [Header("Components")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargetingCollider))] private Object skillTargetingCollider = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDraggable))] private Object draggable = null;
   
   [Header("Inspector References")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;
   
   
   #endregion

   #region PROPERTIES

   public ISkillTargetingCollider SkillTargetingCollider => skillTargetingCollider as ISkillTargetingCollider;
   public IDraggable Draggable => draggable as IDraggable;

   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkillsDisplay as IHeroSkillsDisplay;

   public Transform Transform => transform;

   #endregion

   #region METHODS
   
   
   

   #endregion
}
