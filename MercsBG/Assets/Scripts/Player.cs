using System;
using System.Collections;
using System.Collections.Generic;
using SO_Assets;
using UnityEngine;
using Object = UnityEngine.Object;


public class Player : MonoBehaviour, IPlayer
{
   #region VARIABLES
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroes))] private Object heroes = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISouls))] private Object souls = null;
   
   [Header("Inspector References")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayerAllianceAsset))] private ScriptableObject playerAlliance = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object otherPlayer = null;

   [Header("Runtime")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private Object selectedHero = null;

   #endregion

   #region PROPERTIES

   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;
   public IHeroes Heroes => heroes as IHeroes;

   public IPlayerAllianceAsset PlayerAlliance
   {
      get => playerAlliance as IPlayerAllianceAsset;
      set => playerAlliance = value as ScriptableObject;
   }
   public IPlayer OtherPlayer => otherPlayer as IPlayer;
   public Canvas Canvas { get; private set; } = null;

   public ISouls Souls => souls as ISouls;

   public IHero SelectedHero { get=> selectedHero as IHero; set => selectedHero = value as Object;}
   
   #endregion

   #region METHODS

   private void Awake()
   {
      Canvas = GetComponent<Canvas>();
   }

   #endregion

}
