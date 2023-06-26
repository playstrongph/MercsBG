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
      Hero.Player.BattleSceneManager.HeroPreview.ShowHeroPreview();
   }

   private void OnMouseUp()
   {
      Hero.Player.BattleSceneManager.HeroPreview.HideHeroPreview();
   }
   
   private void OnMouseEnter()
   {
      Hero.Player.BattleSceneManager.HeroPreview.ShowHeroPreviewOnMouseEnter();
   }

   private void OnMouseExit()
   {
      Hero.Player.BattleSceneManager.HeroPreview.HideHeroPreviewOnMouseExit();
   }

   #endregion
}
