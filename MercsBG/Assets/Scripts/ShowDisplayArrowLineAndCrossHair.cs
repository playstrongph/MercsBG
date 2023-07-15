﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDisplayArrowLineAndCrossHair : MonoBehaviour
{
   #region VARIABLES

   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDisplaySkillTargeting))] private Object displaySkillTargeting = null;
    
   
   private readonly List<Vector3> _controlPoints = new List<Vector3>();
   private readonly List<GameObject> _arrowNodes = new List<GameObject>();
   
   //This determines the scale of the nodes
   [SerializeField] private float scaleFactor = 1f;
   
   //This 'normalizes' the distance to be used as an index
   [SerializeField] private float distanceDivisor = 30f;
   
   //This is a factor used in the bezier Curve calculations
   [SerializeField] private float tFactor = 0.08f;
   
   //Integer difference between current mouse position and the skill visual position
   private readonly int _intDifference = 0;
   
   
   
   
   #endregion
        
   #region PROPERTIES

   private IDisplaySkillTargeting DisplaySkillTargeting => displaySkillTargeting as IDisplaySkillTargeting;     

   #endregion
      
   #region METHODS

   public void TurnOn()
   {
      
   }


   private void Awake()
   {
      //Create Bezier Curve control points - P0,P1, and P2
      for (int i = 0; i < 3; i++)
      {
         _controlPoints.Add(Vector3.zero);
      }

      foreach (var node in DisplaySkillTargeting.SkillTargetingGameObjects.Nodes)
      {
         _arrowNodes.Add(node);
      }
      
   }
   
   private void ShowArrow(Vector3 notNormalized, Vector3 direction)
   {
      //TODO: mouseTransform to be replaced by hero target's transform
      var selectedTargetHero = DisplaySkillTargeting.SkillVisual.Skill.HeroSkills.SelectedTargetHero;

      var rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
      var arrow = DisplaySkillTargeting.SkillTargetingGameObjects.Arrow;
      
      //Show arrow and nodes
      DisplaySkillTargeting.SkillTargetingGameObjects.ShowTargetArrow();
      
      //Set the arrow position to the selected target hero position
      arrow.gameObject.transform.position = selectedTargetHero.Transform.position - 15f * direction;
      
      //Set the arrow rotation to the direction of the target from the origin
      arrow.gameObject.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
   }
   
       
   private void ShowArrowNodes()
   {
      //TODO: mouseTransform to be replaced by hero target's transform
      var selectedTargetHero = DisplaySkillTargeting.SkillVisual.Skill.HeroSkills.SelectedTargetHero;
      
      //Transform where the mouse currently is
      var heroTargetTransform = selectedTargetHero.Transform;

      //P0 is where the mouse is at
      _controlPoints[2] = heroTargetTransform.position;
           
      //P2 is where the source (skill parent) is at
      _controlPoints[0] = DisplaySkillTargeting.Transform.position;

      //Halfway between P0 and P2, with a height of Z
      _controlPoints[1] =
         _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);
      
      
      //Varying index based on _arrowNodes count and distance
      var nodeIndex = Mathf.Floor(Mathf.RoundToInt(_intDifference / distanceDivisor));
      
      
      //Clamp the Node index
      nodeIndex = Mathf.Clamp(nodeIndex, 1, _arrowNodes.Count);

      
      for (int k = 0; k < _arrowNodes.Count; k++)
      {
         var indexTracker = 0;
         
         for (int i = 0; i < nodeIndex; i++)
         {
            indexTracker = i;

            DisplaySkillTargeting.SkillTargetingGameObjects.ShowTargetNode(i);
         
            //Values determined through trial and error
            var t = (i+ tFactor) / ((nodeIndex - 1) + 1f);  //Use the number of nodes enabled by the distance

            //Quadratic Bezier Curve
            _arrowNodes[i].transform.position =
               Mathf.Pow(1 - t, 2) * _controlPoints[0] +           //(1-t)^2*P0
               2 * Mathf.Pow(1 - t, 1) * t * _controlPoints[1] +   //2*(1-t)*t*p1
               Mathf.Pow(t, 2) * _controlPoints[2];                //t^2*P2


            //Calculates rotation for each arrow node
            if (i>0)
            {
               var euler = new Vector3(0, 0, 
                  Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - _arrowNodes[i - 1].transform.position));
            
               _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
            }
            else
            {
               var euler = new Vector3(0, 0, 
                  Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - DisplaySkillTargeting.Transform.position));
            
               _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
            }

            //calculates scales for each arrow node
            var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               
            _arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);
         }

         if (k != indexTracker)
         {
            DisplaySkillTargeting.SkillTargetingGameObjects.HideTargetNode(k);
         }
      }

   }


   private void ShowTargetCrossHair()
   {
      //TODO: mouseTransform to be replaced by hero target's transform
      var selectedTargetHero = DisplaySkillTargeting.SkillVisual.Skill.HeroSkills.SelectedTargetHero;
      
      //Display CrossHair
      DisplaySkillTargeting.SkillTargetingGameObjects.ShowCrossHair();

      //Transfer CrossHair transform to target
      DisplaySkillTargeting.SkillTargetingGameObjects.CrossHair.gameObject.transform.position = selectedTargetHero.Transform.position;
   }



   #endregion
}
