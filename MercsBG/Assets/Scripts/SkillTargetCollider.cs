﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;

   
        

   #endregion
        
   #region PROPERTIES
   
   private ISkillVisual SkillVisual => skillVisual as ISkillVisual;

   #endregion
        
   #region METHODS

   

   private void OnMouseDown()
   {
      ShowSkillPreview();
      
      //TEST
      SelectSkill();
   }

   

   private void OnMouseEnter()
   {
      ShowSkillPreviewOnMouseEnter();
   }

   private void OnMouseUp()
   {
      HideSkillPreview();
   }

   private void OnMouseExit()
   {
      HideSkillPreviewOnMouseExit();
   }


   private void ShowSkillPreview()
   {
      var skill = SkillVisual.Skill;
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      skillPreview.ShowSkillPreview.TurnOn(skill);
   }
   
   private void ShowSkillPreviewOnMouseEnter()
   {
      var skill = SkillVisual.Skill;
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      skillPreview.ShowSkillPreview.TurnOnAtMouseEnter(skill);
   }
   
   private void HideSkillPreview()
   {
      var skill = SkillVisual.Skill;
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      skillPreview.ShowSkillPreview.TurnOff();
   }
   
   private void HideSkillPreviewOnMouseExit()
   {
      var skill = SkillVisual.Skill;
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      skillPreview.ShowSkillPreview.TurnOffAtMouseExit();
   }
   
   //TEST
   private void SelectSkill()
   {
      var battleSceneManager = SkillVisual.SkillVisuals.HeroSkillsDisplay.BattleSceneManager;
      SkillVisual.SkillVisuals.HeroSkillsDisplay.SelectedSkillVisual = SkillVisual;
      
      //Transfer skill targeting position
      battleSceneManager.SkillTargeting.Transform.position = SkillVisual.Transform.position;
      
      
   }


   #endregion
}
