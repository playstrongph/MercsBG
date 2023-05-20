using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTargeting : MonoBehaviour
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



   #endregion
}
