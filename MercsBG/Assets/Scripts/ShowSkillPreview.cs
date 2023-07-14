using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ShowSkillPreview : MonoBehaviour, IShowSkillPreview
{
   #region VARIABLES

   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillPreview))] private Object skillPreview = null;
   
   private readonly float _displayDelay = 0.5f;
  
   private bool _enablePreview = false;

   private Coroutine _delayCoroutine = null;

   #endregion

   #region PROPERTIES
   
   public ISkillPreview SkillPreview => skillPreview as ISkillPreview;
   

   #endregion

   #region METHODS

   public void TurnOn(ISkill skill)
   {
      _enablePreview = true;
     
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
      _delayCoroutine = StartCoroutine(ShowPreview(skill));

   }

   public void TurnOnAtMouseEnter(ISkill skill)
   {
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
        
      _delayCoroutine = StartCoroutine(ShowPreview(skill));
   }

   public void TurnOff()
   {
      _enablePreview = false;
      SkillPreview.Canvas.enabled = false;
        
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
   }
   
   public void TurnOffAtMouseExit()
   {
      //_enablePreview = false;
      SkillPreview.Canvas.enabled = false;
        
      //Stop coroutine if running previously
      if(_delayCoroutine!=null) StopCoroutine(_delayCoroutine);
   }
   
   private IEnumerator ShowPreview(ISkill skill)
   {
      yield return new WaitForSeconds(_displayDelay);
        
      if (_enablePreview)
      {
         SkillPreview.Canvas.enabled = true;
         
         UpdateSkillPreview(skill);
      }

      _delayCoroutine = null;
   }

   private void UpdateSkillPreview(ISkill skill)
   {
      var heroClass = skill.HeroSkills.CasterHero.HeroInformation.HeroClass;
      var skillCooldown = skill.SkillAttributes.SkillCooldown;
      var skillSpeed = skill.SkillAttributes.SkillSpeed;
      
      //Update Frame
      heroClass.SetSkillPreviewFrameColor(SkillPreview.SkillPreviewFrames);
      
      //Update Skill Graphic 
      SkillPreview.SkillGraphic.sprite = skill.SkillAttributes.SkillSprite;
      
      //Update Cooldown Graphic and cooldown text
      skill.SkillAttributes.SkillType.SetCooldownGraphicAndText(SkillPreview.CooldownGraphic, SkillPreview.CooldownText, skillCooldown);
      
      //Update Speed Graphic and speed text
      skill.SkillAttributes.SkillType.SetSpeedGraphicAndText(SkillPreview.SpeedGraphic, SkillPreview.SpeedText, skillSpeed);
      
      //Update Texts
      SkillPreview.NameText.text = skill.SkillAttributes.SkillName;
      SkillPreview.ElementText.text = skill.SkillAttributes.SkillElement.ElementName;
      SkillPreview.DescriptionText.text = skill.SkillAttributes.Description;
   }

  

   #endregion
}
