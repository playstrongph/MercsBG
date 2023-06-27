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
         UpdateHeroPreviewSkills(hero);
      }

      _delayCoroutine = null;
   }

   private void UpdateHeroPreviewHero(IHero hero)
   {
      HeroPreviewHero.HeroGraphic.sprite = hero.HeroVisual.HeroGraphic.sprite;

      HeroPreviewHero.AttackText.text = hero.HeroAttributes.Attack.ToString();
      HeroPreviewHero.HealthText.text = hero.HeroAttributes.Health.ToString();
      HeroPreviewHero.ArmorText.text = hero.HeroAttributes.Armor.ToString();
      HeroPreviewHero.NameText.text = hero.HeroInformation.HeroName;

      HeroPreviewHero.RaceText.text = hero.HeroInformation.HeroRace.RaceName;

      hero.HeroInformation.HeroClass.SetHeroPreviewFrameColor(this);
      
      //Armor Display
      HeroPreviewHero.ArmorGraphic.enabled = hero.HeroAttributes.Armor > 0;
      HeroPreviewHero.ArmorText.enabled = hero.HeroAttributes.Armor > 0;
   }

   private void UpdateHeroPreviewSkills(IHero hero)
   {
      var heroSkills = hero.HeroSkills.AllSkills;
      
      //Initialize the displayed game objects
      foreach (var heroPreviewSkill in HeroPreviewSkills)
      {
         heroPreviewSkill.Transform.gameObject.SetActive(false);
      }

      for (int i = 0; i < hero.HeroSkills.InUseHeroSkills; i++)
      {
         var previewSkills = HeroPreviewSkills[i];
         var skillAttributes = heroSkills[i].SkillAttributes;
         
         previewSkills.Transform.gameObject.SetActive(true);
           
           //Frame Color
           hero.HeroInformation.HeroClass.SetSkillPreviewFrameColor(previewSkills.SkillPreviewFrames);

           //Images
           previewSkills.SkillGraphic.sprite = skillAttributes.SkillSprite;
           //TODO: Speed and Cooldown Displays
           
           //Text values
           previewSkills.SkillDescriptionText.text = skillAttributes.Description;
           previewSkills.SkillCooldownText.text = skillAttributes.SkillCooldown.ToString();
           previewSkills.SkillElementText.text = skillAttributes.SkillElement.ElementName;
           previewSkills.SkillNameText.text = skillAttributes.SkillName;
           previewSkills.SkillSpeedText.text = skillAttributes.SkillSpeed.ToString();
         
           //Skill Speed and graphic display
           previewSkills.SkillSpeedText.enabled = skillAttributes.SkillSpeed > 0;
           previewSkills.SpeedGraphic.enabled = skillAttributes.SkillSpeed > 0;
         
           //Skill Cooldown Graphic and Text
           previewSkills.SkillCooldownText.enabled = skillAttributes.SkillCooldown > 0;
           previewSkills.CooldownGraphic.enabled = skillAttributes.SkillCooldown > 0;


      }
      
   }



   #endregion
}
