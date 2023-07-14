using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectsSkill : MonoBehaviour, IPlayerSelectsSkill
{
   #region VARIABLES
   
   [Header(("Inspector References"))]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;

   /*[Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;*/
   
  

   private Vector3 _skillTargetingOrigin = new Vector3(); 

   #endregion
        
   #region PROPERTIES
   
   private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;

   //private ISkillVisual SkillVisual => skillVisual as ISkillVisual; 
        

   #endregion
        
   #region METHODS
   
   private void Awake()
   {
      _skillTargetingOrigin = SkillTargeting.Transform.position;
   }

   /// <summary>
   /// Select skill actions after status checks
   /// </summary>
   public void SelectedSkillChecks()
   {
      var skillType = SkillTargeting.SkillVisual.Skill.SkillAttributes.SkillType;
      var skillVisualCollider = SkillTargeting.SkillVisual.SkillVisualCollider;
      
      skillType.SelectSkillActions(skillVisualCollider);
   }
   
   public void DeselectSkillActions()
   {
      var battleSceneManager = SkillTargeting.BattleSceneManager;
      var skillTargetingOrigin = _skillTargetingOrigin; 

      //Reset skillTargeting Transform to it's initial position
      SkillTargeting.Transform.position = skillTargetingOrigin;
      
      //Enable Draggable
      SkillTargeting.Draggable.DisableDraggable();
      
      //Hide Valid Targets Glow
      SkillTargeting.SkillTargets.HideValidTargetsGlow();
      
      //TODO: Test - Clear valid targets
      SkillTargeting.SkillTargets.ClearValidTargets();
   }
   
   /// <summary>
   /// Selects the skill if the following criteria are met:
   /// 1) Basic or Active Skill 2) Enabled Skill 3) Skill is Ready (cooldown)
   /// </summary>
   public void SelectSkillActions()
   {
      var heroSkillsDisplay = SkillTargeting.SkillVisual.SkillVisuals.HeroSkillsDisplay;
      
      //TODO: The below 3 methods should only be called for Active SKills - Enabled SKills - Ready Skills 
      
      //Set selected skill Visual
      heroSkillsDisplay.SelectedSkillVisual = SkillTargeting.SkillVisual;
      
      //Transfer skill targeting position
      SkillTargeting.Transform.position = SkillTargeting.SkillVisual.Transform.position;
      
      //Enable Draggable
      SkillTargeting.Draggable.EnableDraggable();
      
      //Show valid targets glow
      SkillTargeting.SkillTargets.ShowValidTargetsGlow();
   }
   
   

   #endregion
}
