using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectsSkill : MonoBehaviour, IPlayerSelectsSkill
{
   #region VARIABLES

   [Header("Components")]
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

   /// <summary>
   /// Select skill actions after status checks
   /// </summary>
   public void SelectedSkillChecks()
   {
      var skillType = SkillVisual.Skill.SkillAttributes.SkillType;
      var skillTargetCollider = SkillVisual.SkillTargetCollider;
      
      skillType.ManualSelectSkill(skillTargetCollider);
   }
   
   public void DeselectAction()
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
   /// Selects the skill if the following criteria are met:
   /// 1) Basic or Active Skill 2) Enabled Skill 3) Skill is Ready (cooldown)
   /// </summary>
   public void SelectedSkillActions()
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
