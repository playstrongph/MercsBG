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

      public override void UpdateHeroSkillsOnDisplay(IHeroSkills heroSkills, IPlayer player)
      {
         //Do Nothing
      }  
      
      public override void DisplaySkillsAndScaleUpHero(IHero hero)
      {
         //Do Nothing
      }     

      #endregion
   }
}
