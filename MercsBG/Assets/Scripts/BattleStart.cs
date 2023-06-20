using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStart : MonoBehaviour, IBattleStart
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;     

   #endregion
        
   #region PROPERTIES

   private IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   #endregion

   #region METHODS

   public void StartAction()
   {
      StartCoroutine(StartAllCoroutines());
   }

   private IEnumerator StartAllCoroutines()
   {

      yield return StartCoroutine(InitializeGameBoard());
      
      yield return StartCoroutine(InitializeAllPlayers());
      
      yield return StartCoroutine(InitializeHeroes());
      
      yield return StartCoroutine(InitializeSkills());
      
      /*yield return StartCoroutine(InitializeSkillQueue());
   
      yield return StartCoroutine(InitializeSkillQueuePreview());  
       
      yield return StartCoroutine(InitializeFightButton());
      
      yield return StartCoroutine(StartBattle());*/
      
      yield return null;
   }
   
   private IEnumerator InitializeGameBoard()
   {
      BattleSceneManager.GameBoard.InitializeGameBoard.StartAction();
      
      yield return null;
   }
   
   private IEnumerator InitializeAllPlayers()
   {
      BattleSceneManager.InitializePlayers.StartAction();
      
      yield return null;
   }
   
   private IEnumerator InitializeHeroes()
   {
      BattleSceneManager.InitializeHeroes.StartAction();
      
      yield return null;
   }

   private IEnumerator InitializeSkills()
   {  
      BattleSceneManager.InitializeSkills.StartAction();
      
      yield return null;
   }


   #endregion
}
