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
   
    
   
   
   


   #endregion
}
