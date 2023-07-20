using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDisplayArrowLineAndCrossHair : MonoBehaviour, IShowDisplayArrowLineAndCrossHair
{
   #region VARIABLES

   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDisplaySkillTargeting))] private Object displaySkillTargeting = null;

   [Header("Factors")]
   [SerializeField] private float distanceMultiplier = 40f;
   //This determines the scale of the nodes
   [SerializeField] private float scaleFactor = 1f;
   
   //This 'normalizes' the distance to be used as an index
   [SerializeField] private float distanceDivisor = 30f;
   
   //This is a factor used in the bezier Curve calculations
   [SerializeField] private float tFactor = 0.08f;
   
   
   //Integer difference between current mouse position and the skill visual position
   private int _intDifference = 0;
   
   private readonly List<Vector3> _controlPoints = new List<Vector3>();
   private readonly List<GameObject> _arrowNodes = new List<GameObject>();
   
   //TEST
   private Vector3 _arrowEuler = new Vector3();
   
   
   
   
   #endregion
        
   #region PROPERTIES

   private IDisplaySkillTargeting DisplaySkillTargeting => displaySkillTargeting as IDisplaySkillTargeting;     

   #endregion
      
   #region METHODS

   public void TurnOn()
   {
      if (DisplaySkillTargeting.SkillVisual == null) return;
      
      ShowArrowNodes();
      ShowArrow();
      ShowTargetCrossHair();
   }

   public void TurnOff()
   {
      DisplaySkillTargeting.SkillTargetingGameObjects.HideArrowAndNodes();
      DisplaySkillTargeting.SkillTargetingGameObjects.HideCrossHair();
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
   
   private void ShowArrow()
   {
      var selectedTargetHero = DisplaySkillTargeting.SkillVisual.Skill.HeroSkills.SelectedTargetHero;
      var selectedTargetHeroPosition = selectedTargetHero.Transform.position;
      var selectedSkill = DisplaySkillTargeting.SkillVisual.Skill.HeroSkills.SelectedCastingSkill;
      
      
      var skillVisualPosition = DisplaySkillTargeting.SkillVisual.Transform.position;
      
      
      var notNormalized = selectedTargetHeroPosition - skillVisualPosition;
      var direction = notNormalized.normalized;
      var distanceFromHero = (direction*distanceMultiplier).magnitude;
      var difference = notNormalized.magnitude - distanceFromHero;
      var arrow = DisplaySkillTargeting.SkillTargetingGameObjects.Arrow;
      var arrowRotation = new Vector3(0, 0, 
         Vector2.SignedAngle(Vector2.up,  selectedTargetHeroPosition - skillVisualPosition ));
      var arrowOffset = 20f;
      
      _intDifference = Mathf.RoundToInt(difference);

      //Show arrow and nodes
      DisplaySkillTargeting.SkillTargetingGameObjects.ShowTargetArrow();
      
      //Set the arrow position to the selected target hero position
      arrow.gameObject.transform.position = selectedTargetHeroPosition - arrowOffset * direction;
      
      //Set the arrow rotation
      arrow.gameObject.transform.rotation = Quaternion.Euler(arrowRotation);
   }
   
       
   private void ShowArrowNodes()
   {
      //Hero target's transform
      var selectedTargetHero = DisplaySkillTargeting.SkillVisual.Skill.HeroSkills.SelectedTargetHero;
      
      //Transform where the mouse currently is
      var heroTargetTransform = selectedTargetHero.Transform;

      //P0 is where the mouse is at
      _controlPoints[2] = heroTargetTransform.position;

      //P2 is where the source (skill parent) is at
      _controlPoints[0] = DisplaySkillTargeting.SkillVisual.Transform.position;

      //Halfway between P0 and P2, with a height of Z
      _controlPoints[1] =
         _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);
      
      
      //skill and target distance
      var pointsDistance = Mathf.RoundToInt((_controlPoints[2] - _controlPoints[1]).magnitude);
      var nodeIndex = Mathf.Floor(Mathf.RoundToInt(pointsDistance / distanceDivisor));

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
               
               //TEST
               _arrowEuler = euler;
            }
            else
            {
               var euler = new Vector3(0, 0, 
                  Vector2.SignedAngle(Vector2.up,  _arrowNodes[i].transform.position - heroTargetTransform.position));
            
               _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
               
               //TEST
               _arrowEuler = euler;
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
