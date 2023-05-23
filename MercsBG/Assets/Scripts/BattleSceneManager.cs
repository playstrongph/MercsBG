using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneManager : MonoBehaviour, IBattleSceneManager
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object mainPlayer = null;
   
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IPlayer))] private Object enemyPlayer = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;


   #endregion

   #region PROPERTIES

   public IPlayer MainPlayer => mainPlayer as IPlayer;
   public IPlayer EnemyPlayer => enemyPlayer as IPlayer;
   
   
   public ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;

   
   
   
   #endregion

   #region METHODS



   #endregion
}
