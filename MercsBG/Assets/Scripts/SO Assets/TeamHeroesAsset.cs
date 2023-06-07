using System;
using System.Collections.Generic;
using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "TeamHeroes", menuName = "Assets/TeamHeroes/NewTeam")]
   public class TeamHeroesAsset : ScriptableObject, ITeamHeroesAsset
   {
      #region VARIABLES

      [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroAsset))] private List<ScriptableObject> heroAssets = new List<ScriptableObject>();  

      #endregion
        
      #region PROPERTIES

      public List<IHeroAsset> HeroAssets
      {
         get
         {
            var iHeroAssetList = new List<IHeroAsset>();
            foreach (var iHeroAsset in heroAssets)
            {
               iHeroAssetList.Add(iHeroAsset as IHeroAsset);  
            }
            return iHeroAssetList;
         }
      }  

      #endregion
        
      #region METHODS

      private void Awake()
      {
         
      }

      #endregion
   }
}
