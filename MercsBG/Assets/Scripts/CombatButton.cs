using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CombatButton : MonoBehaviour, ICombatButton
{
   #region VARIABLES

   [SerializeField] private Image buttonImage = null;
   [SerializeField] private Canvas canvas = null;
   [SerializeField] private List<Sprite> buttonSprites = new List<Sprite>();
   [SerializeField] private TextMeshProUGUI buttonText = null;
   [SerializeField] private Button button = null;


   #endregion

   #region PROPERTIES

   private Image ButtonImage => buttonImage;
   
   /// <summary>
   /// Sequence: Grey - Green - Yellow
   /// </summary>
   private List<Sprite> ButtonSprites => buttonSprites;

   private TextMeshProUGUI ButtonText => buttonText;

   private Button Button => button;


   #endregion

   #region METHODS
   
   private void ButtonAction()
   {
      //TEST
      Debug.Log("Combat Button Action");
      //Good practice to disable after first click
      //Button.interactable = false;
      
      //Test method only
      var x = Random.Range(0, 3);
      ButtonImage.sprite = ButtonSprites[x];
   }

   public Canvas Canvas => canvas;

   public void SetButtonText(string text)
   {
      ButtonText.text = text;
   }

   public void SetGreyButton()
   {
      ButtonImage.sprite = ButtonSprites[0];
   }
   
   public void SetGreenButton()
   {
      ButtonImage.sprite = ButtonSprites[1];
   }
   
   public void SetYellowButton()
   {
      ButtonImage.sprite = ButtonSprites[2];
   }
   
   




   #endregion
}
