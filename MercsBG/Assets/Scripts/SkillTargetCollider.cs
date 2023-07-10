using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class SkillTargetCollider : MonoBehaviour, ISkillTargetCollider
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;

   private Vector3 _skillTargetingOrigin = new Vector3(); 
   
        

   #endregion
        
   #region PROPERTIES
   
   public ISkillVisual SkillVisual => skillVisual as ISkillVisual;

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
   
   

   public void DeselectSkill()
   {
      var battleSceneManager = SkillVisual.SkillVisuals.HeroSkillsDisplay.BattleSceneManager;
      var skillTargeting = battleSceneManager.SkillTargeting;
      var skillTargetingOrigin = _skillTargetingOrigin; 

      //Transfer skill targeting position
      skillTargeting.Transform.position = skillTargetingOrigin;
      
      //Enable Draggable
      skillTargeting.Draggable.DisableDraggable();
   }
   
   /// <summary>
   /// Select skill actions after status checks
   /// </summary>
   private void SelectSkill()
   {
      var skillType = SkillVisual.Skill.SkillAttributes.SkillType;
      
      skillType.ManualSelectSkill(this);
      
   }
   
   
   /// <summary>
   /// Selects the skill if the following criteria are met:
   /// 1) Basic or Active Skill 2) Enabled Skill 3) Skill is Ready (cooldown)
   /// </summary>
   public void ManualSelectSkill()
   {
      var battleSceneManager = SkillVisual.SkillVisuals.HeroSkillsDisplay.BattleSceneManager;
      var skillTargeting = battleSceneManager.SkillTargeting;
      var heroSkillsDisplay = SkillVisual.SkillVisuals.HeroSkillsDisplay;
      
      //TODO: The below 3 methods should only be called for Active SKills - Enabled SKills - Ready Skills 
      
      //Set selected skill Visual
      heroSkillsDisplay.SelectedSkillVisual = SkillVisual;
      
      //Transfer skill targeting position
      skillTargeting.Transform.position = SkillVisual.Transform.position;
      
      //Enable Draggable
      skillTargeting.Draggable.EnableDraggable();
   }









   #endregion
}
