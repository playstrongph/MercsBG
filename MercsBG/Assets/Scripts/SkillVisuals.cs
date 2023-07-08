using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillVisuals : MonoBehaviour, ISkillVisuals
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private List<Object> heroSkillVisuals = new List<Object>();

   [Header("COMPONENTS")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPanelFrames))] private Object skillPanelFrames = null;

   [Header("RUNTIME")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object selectedSkillVisual = null;

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

   public ISkillVisual SelectedSkillVisual 
   { 
      get => selectedSkillVisual as ISkillVisual;
      set => selectedSkillVisual = value as Object;
   }

   public Transform Transform => transform;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
