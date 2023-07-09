using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLineAndCrossHair : MonoBehaviour, IShowLineAndCrossHair
{
   #region VARIABLES
   
   
   [SerializeField] private float distanceMultiplier = 40;
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
    
   
   private readonly List<Vector3> _controlPoints = new List<Vector3>();
   private readonly List<GameObject> _arrowNodes = new List<GameObject>();
   [SerializeField] private float scaleFactor = 1f;
   
   
   #endregion
        
   #region PROPERTIES

   private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;     

   #endregion
        
   #region METHODS

   public void TurnOn()
   {
      var thisTransform = transform;
      
      var notNormalized = thisTransform.position - SkillTargeting.Transform.position;
      
      var direction = notNormalized.normalized;
      var distanceFromHero = (direction*distanceMultiplier).magnitude;
      var difference = notNormalized.magnitude - distanceFromHero;
      var intDifference = Mathf.RoundToInt(difference);
      var distanceLimit = 0f;  //default value is zero

      if (intDifference > distanceLimit)  //if there is some distance between skill position and mouse position
      {
         ShowArrow(notNormalized,direction);
            
         //SkillTargetCollider.TargetNodes.ShowArrowNodes();
         ShowArrowNodes();
            
         //ShowTargetCrossHair();
         
      }
      else  //if there is NO distance between skill position and mouse position
      {
         SkillTargeting.SkillTargetingCollider.HideArrowAndNodes();
      }
   }
   
   private void Awake()
   {
      //Create Bezier Curve control points - P0,P1, and P2
      for (int i = 0; i < 3; i++)
      {
         _controlPoints.Add(Vector3.zero);
      }

      foreach (var node in SkillTargeting.SkillTargetingCollider.Nodes)
      {
         _arrowNodes.Add(node);
      }
   }
   
   private void ShowArrow(Vector3 notNormalized, Vector3 direction)
   {
      var rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
      var arrow = SkillTargeting.SkillTargetingCollider.Arrow;
      
      //Show arrow and nodes
      SkillTargeting.SkillTargetingCollider.ShowArrowAndNodes();
      
      //Set the arrow position to the current mouse position
      arrow.gameObject.transform.position = transform.position - 15f * direction;
      
      //Set the arrow rotation to the direction of the target from the origin
      arrow.gameObject.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
   }
   
       
   private void ShowArrowNodes()
   {
      //Transform where the mouse currently is
      var mouseTransform = transform;

      //Transform where the skill parent currently is
      var skillTransform = SkillTargeting;
           
      //P0 is where the mouse is at
      _controlPoints[0] = mouseTransform.position;
           
      //P2 is where the source (skill parent) is at
      _controlPoints[2] = SkillTargeting.Transform.position;

      //Halfway between P0 and P2, with a height of Z
      _controlPoints[1] =
         _controlPoints[0] + ((_controlPoints[2] - _controlPoints[0])/2) + new Vector3(0, 0, 100);


      for (var i = 0; i < _arrowNodes.Count; i++)
      {
               
         //Don't ask.  Haha!
         var t = (i+1.5f) / ((_arrowNodes.Count - 1) + 1f);

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
   
         //calculates scales for each arrow node
         var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               
         _arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);

         //_arrowNodes[i].GetComponent<Image>().enabled = true;
               
      }//End of for statement
   }
    
   
   
   


   #endregion
}
