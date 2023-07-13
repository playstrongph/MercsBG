using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargets : MonoBehaviour, ISkillTargets
{
   #region VARIABLES
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillVisual))] private Object skillVisual = null;
   
   [Header("Runtime")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private List<Object> validTargets = new List<Object>();

   #endregion

   #region PROPERTIES
   
   private ISkillVisual SkillVisual => skillVisual as ISkillVisual;
   
   private List<IHero> ValidTargets
   {
      get
      {
         var newValidTargets = new List<IHero>();
         foreach (var validTarget in validTargets)
         {
            newValidTargets.Add(validTarget as IHero);
         }

         return newValidTargets;
      }
   }


   #endregion

   #region METHODS
   
   public List<IHero> GetValidTargets()
   {
      var skill = SkillVisual.Skill;
      
      var validHeroTargets = skill.SkillAttributes.SkillTarget.GetHeroTargets(skill.CasterHero);

      validTargets.Clear();

      foreach (var hero in validHeroTargets)
      {
         validTargets.Add(hero as Object);
      }

      //Note: validHeroTargets can be returned directly - ValidTargets setup so you can see valid targets in the SkillTargetCollider Component in the inspector
      return ValidTargets;

      //TODO: Note Special circumstances in targeting are resolved in SkillTarget.HeroTargets
   }
   
   /// <summary>
   /// Clear valid Targets List
   /// </summary>
   public void ClearValidTargets()
   {
      validTargets.Clear();
      ValidTargets.Clear();
   }
   
   /// <summary>
   /// Called by SkillTargetCollider On Mouse Down
   /// Color of glow determined by skill Target Type
   /// </summary>
   public void ShowValidTargetsGlow()
   {
      
      //TODO: Should pass by Skill Readiness and Skill Enabled Status
      

      var heroes = GetValidTargets();

      var skill = SkillVisual.Skill;

      foreach (var hero in heroes)
      {
         skill.SkillAttributes.SkillTarget.ShowTargetsGlow(hero);
      }
      
   }
   
   /// <summary>
   /// Called by SkillTargetCollider On Mouse Down
   /// Color of glow determined by skill Target Type
   /// </summary>
   public void HideValidTargetsGlow()
   {
      var heroes = GetValidTargets();
      var skill = SkillVisual.Skill;
      
      foreach (var hero in heroes)
      {
         skill.SkillAttributes.SkillTarget.HideTargetsGlow(hero);
      }
   }

   #endregion
}
