using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillVisuals : MonoBehaviour, ISkillVisuals
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private List<Object> heroSkillVisuals = new List<Object>();
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelFrames))] private Object skillPanelFrames = null;

   [Header("Inspector References")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkillsDisplay))] private Object heroSkillsDisplay = null;
   
   #endregion

   #region PROPERTIES

   public List<ISkillVisual> HeroSkillVisuals
   {
      get
      {
         var newHeroSkillVisuals = new List<ISkillVisual>();
         {
            foreach (var heroSkillVisual in heroSkillVisuals)
            {
               newHeroSkillVisuals.Add(heroSkillVisual as ISkillVisual);
            }
         }
         return newHeroSkillVisuals;
      }
   }
   
   public ISkillPanelFrames SkillPanelFrames => skillPanelFrames as ISkillPanelFrames;
   
   public IHeroSkillsDisplay HeroSkillsDisplay => heroSkillsDisplay as IHeroSkillsDisplay;
   
   


   public Transform Transform => transform;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
