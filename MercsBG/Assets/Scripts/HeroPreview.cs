﻿using System.Collections;
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

   public void ShowHeroPreview()
   {
      _enablePreview = true;
     
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
      _delayCoroutine = StartCoroutine(ShowPreview());
   }
   
   public void ShowHeroPreviewOnMouseEnter()
   {
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
        
      _delayCoroutine = StartCoroutine(ShowPreview());
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
   
   private IEnumerator ShowPreview()
   {
      yield return new WaitForSeconds(_displayDelay);
        
      if (_enablePreview)
      {
         Canvas.enabled = true;
         
         //TODO: Update Hero Preview Info
         //TODO: Update Skill Preview Info
      }

      _delayCoroutine = null;
   }

   #endregion
}
