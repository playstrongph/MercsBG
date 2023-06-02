using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoard : MonoBehaviour, IGameBoard
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;
   
   [SerializeField] private Canvas canvas = null;

   [SerializeField] private Image boardImage = null;

   #endregion

   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public Canvas Canvas => canvas;
   public Image BoardImage => boardImage;


   #endregion

   #region METHODS



   #endregion
}
