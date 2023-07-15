using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSkillTarget : MonoBehaviour, ISelectSkillTarget
{
   #region VARIABLES
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
        

   #endregion
   
   
        
   #region PROPERTIES
   
   private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;
        

   #endregion
        
   #region METHODS

   public void SelectTarget()
   {
      SetSelectedTargetHeroAndCastingSkill();  //Logic
      
      //TODO - ShowDisplaySkillTargeting @ DisplaySkillTargeting
   }
   
   
   /// <summary>
   /// Set and update the selected target hero and the selected casting skill
   /// when a skill selects a valid target
   /// </summary>
   private void SetSelectedTargetHeroAndCastingSkill()
   {
      var castingSkill = SkillTargeting.SkillVisual.Skill;
      var heroSkills = castingSkill.CasterHero.HeroSkills;
      // ReSharper disable once PossibleNullReferenceException
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      //Store at most 5 ray cast hits
      var mResults = new RaycastHit[5];
      //ray traverses all layers
      var layerMask = ~0;
      //Get the current list of valid targets
      var validTargets = SkillTargeting.SkillTargets.GetValidTargets();
      //TODO: Test
      var displaySkillTargeting = SkillTargeting.BattleSceneManager.DisplaySkillTargeting;
      
      //RayCast
      int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity,layerMask);
      
      //Clear the list of valid targets in skillTargeting
      SkillTargeting.SkillTargets.ClearValidTargets();
      
      for (var i = 0; i < hitsCount; i++)
      {
         //If raycast finds a valid hero target
         if (mResults[i].transform.GetComponent<IHero>() != null)
         {
            var targetHero = mResults[i].transform.GetComponent<IHero>();
            
            //Set the local skill selected target hero to the hero found if it belongs to the list of valid targets, else set it to null
            heroSkills.SelectedTargetHero = validTargets.Contains(targetHero) ?targetHero : null;
            
            //Set the casting skill
            heroSkills.SelectedCastingSkill = validTargets.Contains(targetHero) ?castingSkill : null;
            
            //TODO: TEST
            //2) ShowSkillTargeting @ DisplaySkillTargeting
            displaySkillTargeting.ShowDisplayArrowLineAndCrossHair.TurnOn();
         }
      } 

   }




   #endregion
}
