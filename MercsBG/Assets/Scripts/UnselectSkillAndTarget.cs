using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnselectSkillAndTarget : MonoBehaviour, IUnselectSkillAndTarget
{
   #region VARIABLES
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
        

   #endregion

   #region PROPERTIES
   
   private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;
        

   #endregion
        
   #region METHODS

   public void UnselectSkill()
   {
      Unselect();
   }
   
   
   /// <summary>
   /// Set and update the selected target hero and the selected casting skill
   /// when a skill selects a valid target
   /// </summary>
   private void Unselect()
   {
      //This is the current skill being cast
      var castingSkill = SkillTargeting.SkillVisual.Skill;
      
      //This is the last selected skill (if any, possible to be null)
      var selectedSkill = castingSkill.HeroSkills.SelectedCastingSkill;
      
      var displaySkillTargeting = SkillTargeting.BattleSceneManager.DisplaySkillTargeting;
      

      if (castingSkill == selectedSkill)
      {
         //TODO: Cancel the selected skill

         //Cancel the selected target and casting skill
         castingSkill.HeroSkills.SelectedTargetHero = null;
         castingSkill.HeroSkills.SelectedCastingSkill = null;
         
         //Turn off skill targeting display
         displaySkillTargeting.ShowDisplayArrowLineAndCrossHair.TurnOff();
      }
   }




   #endregion
}
