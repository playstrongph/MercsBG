using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroesStatusList : MonoBehaviour, IHeroesStatusList
{
   #region VARIABLES

   [Header("Components")] 
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object player = null;
   
   
   [Header("Runtime")]
   
   //For inspector display purposes only - not required logically
   [SerializeField] protected List<Object> aliveHeroes = new List<Object>();
   
   //For inspector display purposes only - not required logically
   [SerializeField] protected List<Object> deadHeroes = new List<Object>();
   
   //For inspector display purposes only - not required logically
   [SerializeField] protected List<Object> extinctHeroes = new List<Object>();
        

   #endregion
        
   #region PROPERTIES

   private IPlayer Player => player as IPlayer;

   public List<IHero> AliveHeroesList { get; private set; }

   public List<IHero> DeadHeroesList { get; private set; }
   
   public List<IHero> ExtinctHeroesList { get; private set; }

   #endregion
        
   #region METHODS
   
   private void Awake()
   {
      AliveHeroesList = new List<IHero>();
      DeadHeroesList = new List<IHero>();
      ExtinctHeroesList = new List<IHero>();
   }
   
   public void AddToAliveHeroList(IHero hero)
   {
      //Debug.Log("Add Hero: " +hero.HeroInformation.HeroName);
      
      AliveHeroesList.Add(hero);
      
      //Inspector display purposes only
      aliveHeroes.Add(hero as Object);
      
      
      
   }
   
   public void RemoveFromAliveHeroList(IHero hero)
   {
      AliveHeroesList.Remove(hero);
      
      //Inspector display purposes only
      aliveHeroes.Remove(hero as Object);

   }

   
   
   public void AddToDeadHeroList(IHero hero)
   {
      DeadHeroesList.Add(hero);
      
      //Inspector display purposes only
      deadHeroes.Add(hero as Object);
   }
   
   public void RemoveFromDeadHeroList(IHero hero)
   {
      DeadHeroesList.Remove(hero);
      
      //Inspector display purposes only
      deadHeroes.Remove(hero as Object);

   }


   public void AddToExtinctHeroList(IHero hero)
   {
      ExtinctHeroesList.Add(hero);
      
      //Inspector display purposes only
      extinctHeroes.Add(hero as Object);
   }
   
   public void RemoveFromExtinctHeroList(IHero hero)
   {
      ExtinctHeroesList.Remove(hero);
      
      //Inspector display purposes only
      extinctHeroes.Remove(hero as Object);
   }
   
   #endregion
}
