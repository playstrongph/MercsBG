using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UsedSkill : MonoBehaviour, IUsedSkill
{
   #region VARIABLES

   [SerializeField] private Image skillGraphic = null;

   #endregion

   #region PROPERTIES

   private Image SkillGraphic => skillGraphic;

   #endregion

   #region METHODS

   public void SetSkillQueueImage(Sprite sprite)
   {
      SkillGraphic.sprite = sprite;
   }

   #endregion
}
