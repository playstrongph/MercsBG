using UnityEngine;

namespace SO_Assets
{
   [CreateAssetMenu(fileName = "EnemyPlayer", menuName = "Assets/PlayerAlliance/EnemyPlayer")]
   public class EnemyPlayerAsset : PlayerAllianceAsset
   {
      #region VARIABLES

        

      #endregion
        
      #region PROPERTIES

        

      #endregion
        
      #region METHODS

      
      
      public override void DisplayHeroSkills(IHero hero)
      {
         //Do Nothing
      }     
      
      public override void ScaleDownHero(IHero hero)
      {
         //Do Nothing
      }
      
      public override void ScaleUpHero(IHero hero)
      {
         //Do Nothing
      }

      #endregion
   }
}
