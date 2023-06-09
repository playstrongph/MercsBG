﻿using System;
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
       var heroSkillsDisplay = GameBoard.BattleSceneManager.HeroSkillsDisplay;
       
       
       DeselectHero();
       

   }

   private void DeselectHero()
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

   #endregion
}
