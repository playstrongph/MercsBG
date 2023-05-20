using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPanelFrames : MonoBehaviour, ISkillPanelFrames
{
   #region VARIABLES
   
   [SerializeField] private Image skillPanel = null;
   [SerializeField] private List<Sprite> frames = new List<Sprite>();
   

   #endregion

   #region PROPERTIES

   private Image SkillPanel => skillPanel;
   
   /// <summary>
   /// The order set in the inspector should be: Grey-Red-Green-Blue
   /// </summary>
   private List<Sprite> Frames => frames;


   #endregion

   #region METHODS

   public void ShowPanel()
   {
      SkillPanel.enabled = true;
   }

   public void HidePanel()
   {
      SkillPanel.enabled = false;
   }

   public void SetRedDefenderFrame()
   {
      SkillPanel.sprite = Frames[1];
   }
   
   public void SetGreenFighterFrame()
   {
      SkillPanel.sprite = Frames[2];
   }
   
   public void SetBlueCasterFrame()
   {
      SkillPanel.sprite = Frames[3];
   }





   #endregion
}
