using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class GameBoard : MonoBehaviour, IGameBoard
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IInitializeGameBoard))]private Object initializeGameBoard = null;
   
   [SerializeField] private Canvas canvas = null;

   [SerializeField] private Image boardImage = null;

   #endregion

   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   
   public IInitializeGameBoard InitializeGameBoard => initializeGameBoard as IInitializeGameBoard;
   public Canvas Canvas => canvas;
   public Image BoardImage => boardImage;

   public IPlayer MainPlayer { get; set; }
   
   public IPlayer EnemyPlayer { get; set; }


   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
