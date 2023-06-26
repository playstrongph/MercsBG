using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPreview : MonoBehaviour, IHeroPreview
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IBattleSceneManager))]private Object battleSceneManager = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewHero))] private Object heroPreviewHero = null;

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IHeroPreviewSkill))] private List<Object> heroPreviewSkills = new List<Object>();

   [SerializeField] private Canvas canvas = null;


   private readonly float _displayDelay = 0.5f;
  
   private bool _enablePreview = false;

   private Coroutine _delayCoroutine = null;
   

   #endregion

   #region PROPERTIES

   
   
   public IBattleSceneManager BattleSceneManager => battleSceneManager as IBattleSceneManager;

   public IHeroPreviewHero HeroPreviewHero => heroPreviewHero as IHeroPreviewHero;

   public List<IHeroPreviewSkill> HeroPreviewSkills
   {
      get
      {
         var newHeroPreviewSkills = new List<IHeroPreviewSkill>();
         foreach (var heroPreviewSkill in heroPreviewSkills)
         {
            newHeroPreviewSkills.Add(heroPreviewSkill as IHeroPreviewSkill);
         }
         return newHeroPreviewSkills;
      }
   }

   public Canvas Canvas => canvas;

   #endregion

   #region METHODS

   public void ShowHeroPreview(IHero hero)
   {
      _enablePreview = true;
     
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
      _delayCoroutine = StartCoroutine(ShowPreview(hero));
   }
   
   public void ShowHeroPreviewOnMouseEnter(IHero hero)
   {
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
        
      _delayCoroutine = StartCoroutine(ShowPreview(hero));
   }

   public void HideHeroPreview()
   {
      _enablePreview = false;
      Canvas.enabled = false;
        
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
   }
   
   public void HideHeroPreviewOnMouseExit()
   {
      //_enablePreview = false;
      Canvas.enabled = false;
        
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
   }
   
   private IEnumerator ShowPreview(IHero hero)
   {
      yield return new WaitForSeconds(_displayDelay);
        
      if (_enablePreview)
      {
         Canvas.enabled = true;
         
         //TODO: Update Hero Preview Info
         UpdateHeroPreviewHero(hero);

         //TODO: Update Skill Preview Info
      }

      _delayCoroutine = null;
   }

   private void UpdateHeroPreviewHero(IHero hero)
   {
      HeroPreviewHero.HeroGraphic.sprite = hero.HeroVisual.HeroGraphic.sprite;

      HeroPreviewHero.AttackText.text = hero.HeroVisual.AttackText.text;
      HeroPreviewHero.HealthText.text = hero.HeroVisual.HealthText.text;
      HeroPreviewHero.ArmorText.text = hero.HeroVisual.ArmorText.text;
      HeroPreviewHero.NameText.text = hero.HeroInformation.HeroName;

      HeroPreviewHero.RaceText.text = hero.HeroInformation.HeroRace.RaceName;
      
      //TEST
      hero.HeroInformation.HeroClass.SetHeroPreviewFrameColor(this);
   }


   #endregion
}
