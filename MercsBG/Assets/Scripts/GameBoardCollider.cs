using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class GameBoardCollider : MonoBehaviour, IGameBoardCollider
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoard))] private Object gameBoard = null;

   #endregion

   #region PROPERTIES
   
   public IGameBoard GameBoard => gameBoard as IGameBoard;

   #endregion

   #region METHODS

   private void OnMouseDown()
   {
       UnselectHero();

       HideDisplaySkillTargeting();
   }

   private void UnselectHero()
   {
       var heroSkillsDisplay = GameBoard.BattleSceneManager.HeroSkillsDisplay;
       var selectedHero = GameBoard.BattleSceneManager.MainPlayer.SelectedHero;
       
       //Disable HeroS
       heroSkillsDisplay.Canvas.enabled = false;
       
       //Scale down selected hero
       if (selectedHero != null)
       {
           selectedHero.Player.PlayerAlliance.ScaleDownHero(selectedHero);
       }
   }

   private void HideDisplaySkillTargeting()
   {
       var displaySkillTargeting = GameBoard.BattleSceneManager.DisplaySkillTargeting;
       
       displaySkillTargeting.ShowDisplayArrowLineAndCrossHair.TurnOff();
   }

   #endregion
}
