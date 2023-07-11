using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayers : MonoBehaviour, IInitializePlayers
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;


   #endregion

   #region PROPERTIES

   private IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   #endregion

   #region METHODS

   public void StartAction()
   {
    
      
      

   }

   #endregion
}
