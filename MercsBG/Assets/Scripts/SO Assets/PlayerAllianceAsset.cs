using UnityEngine;

namespace SO_Assets
{
   public class PlayerAllianceAsset : ScriptableObject, IPlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      public virtual void DisplayHeroSkills(IHero hero)
      {
         /*
         //Logic below is for ally heroes only 
         var newScale = new Vector3(1.5f, 1.5f, 1f);
         hero.HeroTransform.localScale = newScale;
         */
      }

      public virtual void ScaleDownHero(IHero hero)
      {
         
      }
      
      public virtual void ScaleUpHero(IHero hero)
      {
         
      }
      

      #endregion
   }
}
