using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusEffect : MonoBehaviour
{
   #region VARIABLES

   [Header("VISUAL ELEMENTS")] 
   [SerializeField] private Canvas canvas = null;
   [SerializeField] private Image frame = null;
   [SerializeField] private Image icon = null;
   [SerializeField] private TextMeshProUGUI counters = null;


   #endregion

   #region PROPERTIES

   public Canvas Canvas => canvas;
   private Image Frame => frame;
   private Image Icon => icon;
   private TextMeshProUGUI Counters => counters;
   
   #endregion

   #region METHODS

   public void SetFrame(Sprite newFrame)
   {
      Frame.sprite = newFrame;
   }

   public void SetIcon(Sprite newIcon)
   {
      Icon.sprite = newIcon;
   }
   
   public void SetCounters(int newCounters)
   {
      Counters.text = newCounters>0 ? newCounters.ToString() : "";
   }


   #endregion
}
