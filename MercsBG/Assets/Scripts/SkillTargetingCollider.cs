using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTargetingCollider : MonoBehaviour, ISkillTargetingCollider
{
   #region VARIABLES

   [SerializeField] private GameObject arrow = null;
   [SerializeField] private GameObject crossHair = null;
   [SerializeField] private List<GameObject> nodes = new List<GameObject>();

   #endregion

   #region PROPERTIES

   private GameObject Arrow => arrow;
   private GameObject CrossHair => crossHair;
   private List<GameObject> Nodes => nodes;

   #endregion

   #region METHODS

   public void ShowArrowAndNodes()
   {
      Arrow.GetComponent<Image>().enabled = true;

      foreach (var node in Nodes)
      {
         node.GetComponent<Image>().enabled = true;
      }
   }
   
   public void HideArrowAndNodes()
   {
      Arrow.GetComponent<Image>().enabled = false;

      foreach (var node in Nodes)
      {
         node.GetComponent<Image>().enabled = false;
      }
   }

   public void ShowCrossHair()
   {
      CrossHair.GetComponent<Image>().enabled = true;
   }
   
   public void HideCrossHair()
   {
      CrossHair.GetComponent<Image>().enabled = false;
   }





   #endregion
}
