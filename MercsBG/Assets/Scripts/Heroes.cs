using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroes : MonoBehaviour, IHeroes
{
   #region VARIABLES
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHero))] private List<Object> playerHeroes = new List<Object>();
   


   #endregion
        
   #region PROPERTIES

   public List<IHero> PlayerHeroes
   {
      get
      {
         var newHeroes = new List<IHero>();
         foreach (var playerHero in playerHeroes)
         {
            newHeroes.Add(playerHero as IHero);
         }
         return newHeroes;
      }
   }

   #endregion
        
   #region METHODS

        

   #endregion
}
