using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGameBoard : MonoBehaviour, IInitializeGameBoard
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IGameBoard))]private Object gameBoard = null;

   #endregion

   #region PROPERTIES

   private IGameBoard GameBoard => gameBoard as IGameBoard;

   #endregion

   #region METHODS

   public void StartAction()
   {
       var battleSceneManager = GameBoard.BattleSceneManager;
       
       //Set the board image and enable the display
       GameBoard.BoardImage.sprite = battleSceneManager.BattleScene1SettingsAsset.BoardImage;
       GameBoard.Canvas.enabled = true;
       
       //Set References
       GameBoard.MainPlayer = battleSceneManager.MainPlayer;
       GameBoard.EnemyPlayer = battleSceneManager.EnemyPlayer;
   }


   #endregion
}
