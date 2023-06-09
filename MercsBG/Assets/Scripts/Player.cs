using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroes))] private Object heroes = null;


   #endregion

   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public IHeroes Heroes => heroes as IHeroes;

   public IPlayer OtherPlayer { get; set; }

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
