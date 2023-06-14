using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Hero : MonoBehaviour, IHero
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkills))] private Object heroSkills = null;


   #endregion

   #region PROPERTIES
   
   public IPlayer Player => player as IPlayer;
   public IHeroVisual HeroVisual => heroVisual as IHeroVisual;
   
   public IHeroSkills HeroSkills => heroSkills as IHeroSkills;

   public GameObject ThisGameObject => this.gameObject;

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
