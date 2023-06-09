﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;

   #endregion
        
   #region PROPERTIES
   
   public ISkillVisual SkillVisual => skillVisual as ISkillVisual;

   #endregion
        
   #region METHODS


   private void OnMouseDown()
   {
      
      var skill = SkillVisual.Skill;
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      
      //Shows skill preview
      skillPreview.ShowSkillPreview.TurnOn(skill);
      
      //Player selects skill
      SkillVisual.PlayerSelectsSkill.SelectedSkillChecks();
      
      //TODO:
      //Check if HeroSkills.SelectedSkill and Current Selected skill are the same.  If they are, deselect the Heroes.SelectedSkill
      
   }

   private void OnMouseUp()
   {
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      
      //Hide Skill Preview
      skillPreview.ShowSkillPreview.TurnOff();
      
      //Player Deselects skill
      SkillVisual.PlayerSelectsSkill.DeselectSkillActions();
      
      //TODO: 
      //1) Set Selected Skill And Target @HeroSkills
      //2) ShowSkillTargeting @ DisplaySkillTargeting
   }
   
   private void OnMouseEnter()
   {
      var skill = SkillVisual.Skill;
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      
      //Show skill preview
      skillPreview.ShowSkillPreview.TurnOnAtMouseEnter(skill);
   }

   private void OnMouseExit()
   {
      var skillPreview = SkillVisual.HeroSkillsDisplay.BattleSceneManager.SkillPreview;
      
      //Hide Skill Preview
      skillPreview.ShowSkillPreview.TurnOffAtMouseExit();
   }


  
   
   
   
   
   
   

   #endregion
}
