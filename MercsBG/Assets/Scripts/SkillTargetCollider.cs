using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;

   private Vector3 _skillTargetingOrigin = new Vector3(); 
   
        

   #endregion
        
   #region PROPERTIES
   
   private ISkillVisual SkillVisual => skillVisual as ISkillVisual;

   #endregion
        
   #region METHODS

   private void Awake()
   {
      _skillTargetingOrigin = SkillVisual.SkillVisuals.HeroSkillsDisplay.BattleSceneManager.SkillTargeting.Transform
         .position;
   }


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
      
      DeselectSkill();
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
      var skillTargeting = battleSceneManager.SkillTargeting;
      var heroSkillsDisplay = SkillVisual.SkillVisuals.HeroSkillsDisplay;
      
      //Set selected skill Visual
      heroSkillsDisplay.SelectedSkillVisual = SkillVisual;
      
      //Transfer skill targeting position
      skillTargeting.Transform.position = SkillVisual.Transform.position;
      
      //Enable Draggable
      skillTargeting.Draggable.EnableDraggable();
   }

   private void DeselectSkill()
   {
      var battleSceneManager = SkillVisual.SkillVisuals.HeroSkillsDisplay.BattleSceneManager;
      var skillTargeting = battleSceneManager.SkillTargeting;
      var skillTargetingOrigin = _skillTargetingOrigin; 

      //Transfer skill targeting position
      skillTargeting.Transform.position = skillTargetingOrigin;
      
      //Enable Draggable
      skillTargeting.Draggable.DisableDraggable();
   }


   #endregion
}
