using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class HeroCollider : MonoBehaviour, IHeroCollider
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object hero = null;


   #endregion

   #region PROPERTIES
   
   public IHero Hero => hero as IHero;
   

   #endregion

   #region METHODS

   private void OnMouseDown()
   {
      Hero.Player.BattleSceneManager.HeroPreview.ShowHeroPreview(Hero);
      
      //TEST
      ShowHeroSkills();

   }

   private void OnMouseUp()
   {
      Hero.Player.BattleSceneManager.HeroPreview.HideHeroPreview();
   }
   
   private void OnMouseEnter()
   {
      Hero.Player.BattleSceneManager.HeroPreview.ShowHeroPreviewOnMouseEnter(Hero);
   }

   private void OnMouseExit()
   {
      Hero.Player.BattleSceneManager.HeroPreview.HideHeroPreviewOnMouseExit();
   }

   
   /// <summary>
   /// TEST
   /// </summary>
   private void ShowHeroSkills()
   {
      var heroSkillsDisplay = Hero.Player.BattleSceneManager.HeroSkillsDisplay;
      
      heroSkillsDisplay.ShowSkillsDisplay.DisplayOn(Hero);
   }



   #endregion
}
