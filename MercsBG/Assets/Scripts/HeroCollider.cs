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
      SelectHero();

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
   /// Displays the skill panel and scales up/down the selected hero
   /// </summary>
   private void SelectHero()
   {
      var playerAlliance = Hero.Player.PlayerAlliance;

      //Scale down previously selected hero
      if (Hero.Player.SelectedHero != null)
      {
         playerAlliance.ScaleDownHero(Hero.Player.SelectedHero);
      }

      //Update Selected Hero
      Hero.Player.SelectedHero = Hero;
      
      Hero.Player.PlayerAlliance.DisplayHeroSkills(Hero);
      playerAlliance.ScaleUpHero(Hero.Player.SelectedHero);
   }



   #endregion
}
