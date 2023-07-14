using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTargetingGameObjects : MonoBehaviour, ISkillTargetingGameObjects
{
   #region VARIABLES

   [SerializeField] private GameObject arrow = null;
   [SerializeField] private GameObject crossHair = null;
   [SerializeField] private List<GameObject> nodes = new List<GameObject>();

   #endregion

   #region PROPERTIES

   public GameObject Arrow => arrow;
   public GameObject CrossHair => crossHair;
   public List<GameObject> Nodes => nodes;

   #endregion

   #region METHODS

   public void ShowTargetArrow()
   {
      Arrow.GetComponent<Image>().enabled = true;
   }

   public void HideTargetNode(int index)
   {
      Nodes[index].GetComponent<Image>().enabled = false;
   }
   
   public void ShowTargetNode(int index)
   {
      Nodes[index].GetComponent<Image>().enabled = true;
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
