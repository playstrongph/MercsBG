using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroMasks : MonoBehaviour
{
   #region VARIABLES

   [SerializeField] private Image maskImage = null;

   [SerializeField] private List<Sprite> maskSprites = new List<Sprite>();

   #endregion

   #region PROPERTIES

   private List<Sprite> MaskSprites => maskSprites;
   private Image MaskImage => maskImage;

   #endregion

   #region METHODS

   public void SetRedMask()
   {
      MaskImage.sprite = MaskSprites[0];
   }
   
   public void SetGreenMask()
   {
      MaskImage.sprite = MaskSprites[1];
   }
   
   public void SetBlueMask()
   {
      MaskImage.sprite = MaskSprites[2];
   }

   #endregion
}
