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

   public void LoadGameBoard()
   {
       GameBoard.BoardImage.sprite = GameBoard.BattleSceneManager.BattleScene1SettingsAsset.BoardImage;

       GameBoard.Canvas.enabled = true;
   }


   #endregion
}
