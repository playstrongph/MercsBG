using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class Hero : MonoBehaviour, IHero
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroSkills))] private Object heroSkills = null;
   
   [Header("COMPONENTS")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroInformation))] private Object heroInformation = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAttributes))] private Object heroAttributes = null;
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroVisual))] private Object heroVisual = null;
   

   #endregion

   #region PROPERTIES
   
   public IPlayer Player => player as IPlayer;
   public IHeroSkills HeroSkills => heroSkills as IHeroSkills;
   public GameObject ThisGameObject => this.gameObject;
   
   //COMPONENTS
   public IHeroInformation HeroInformation => heroInformation as IHeroInformation;
   public IHeroAttributes HeroAttributes => heroAttributes as IHeroAttributes;
   public IHeroVisual HeroVisual => heroVisual as IHeroVisual;
   

   #endregion

   #region METHODS

   private void Awake()
   {
      
   }

   #endregion
}
