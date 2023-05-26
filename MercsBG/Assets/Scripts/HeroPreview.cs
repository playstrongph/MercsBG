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



   #endregion
}
