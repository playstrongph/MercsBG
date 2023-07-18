using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowArrowLineAndCrossHair : MonoBehaviour, IShowArrowLineAndCrossHair
{
   #region VARIABLES
   
   
   [SerializeField] private float distanceMultiplier = 40f;
   
   [Header("Components")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
    
   
   private readonly List<Vector3> _controlPoints = new List<Vector3>();
   private readonly List<GameObject> _arrowNodes = new List<GameObject>();
   
   //This determines the scale of the nodes
   [SerializeField] private float scaleFactor = 1f;
   
   //This 'normalizes' the distance to be used as an index
   [SerializeField] private float distanceDivisor = 30f;
   
   //This is a factor used in the bezier Curve calculations
   [SerializeField] private float tFactor = 0.08f;
   
   //Integer difference between current mouse position and the skill visual position
   private int _intDifference = 0;
   
   
   
   
   #endregion
        
   #region PROPERTIES

   private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;     

   #endregion
        
   #region METHODS

   public void TurnOn()
   {
      //where the mouse currently is
      var thisTransform = transform;
      
      //SkillTargeting position is the skill visual's position
      var notNormalized = thisTransform.position - SkillTargeting.Transform.position;
      
      var direction = notNormalized.normalized;
      
      var distanceFromHero = (direction*distanceMultiplier).magnitude;
      
      var difference = notNormalized.magnitude - distanceFromHero;
      
      var distanceLimit = 0f;  //default value is zero
      
      _intDifference = Mathf.RoundToInt(difference);

      if (_intDifference > distanceLimit)  //if there is some distance between skill position and mouse position
      {
         ShowArrow(notNormalized,direction);
            
         //SkillTargetCollider.TargetNodes.ShowArrowNodes();
         ShowArrowNodes();
         
         //Enable Box Collider
         SkillTargeting.Draggable.ArrowCollider.enabled = true;

         //Show cross hair for valid targets
         ShowTargetCrossHair();

      }
      else  //if there is NO distance between skill position and mouse position
      {
         //Disable Box Collider
         SkillTargeting.Draggable.ArrowCollider.enabled = false;
         
         SkillTargeting.SkillTargetingGameObjects.HideArrowAndNodes();
         
         SkillTargeting.SkillTargetingGameObjects.HideCrossHair();
      }
   }
   
   private void Awake()
   {
      //Create Bezier Curve control points - P0,P1, and P2
      for (int i = 0; i < 3; i++)
      {
         _controlPoints.Add(Vector3.zero);
      }

      foreach (var node in SkillTargeting.SkillTargetingGameObjects.Nodes)
      {
         _arrowNodes.Add(node);
      }
      
   }
   
   private void ShowArrow(Vector3 notNormalized, Vector3 direction)
   {
      var rotZ = Mathf.Atan2(notNormalized.y, notNormalized.x) * Mathf.Rad2Deg;
      var arrow = SkillTargeting.SkillTargetingGameObjects.Arrow;
      
      //Show arrow and nodes
      SkillTargeting.SkillTargetingGameObjects.ShowTargetArrow();
      
      //Set the arrow position to the current mouse position
      arrow.gameObject.transform.position = transform.position - 15f * direction;
      
      //Set the arrow rotation to the direction of the target from the origin
      arrow.gameObject.transform.rotation = Quaternion.Euler(0f,0f,rotZ-90);
   }
   
       
   private void ShowArrowNodes()
   {
      //Transform where the mouse currently is
      var mouseTransform = transform;

      //P0 is where the mouse is at
      _controlPoints[2] = mouseTransform.position;
           
      //P2 is where the source (skill parent) is at
      _controlPoints[0] = SkillTargeting.Transform.position;

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

            SkillTargeting.SkillTargetingGameObjects.ShowTargetNode(i);
         
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
                  Vector2.SignedAngle(Vector2.up, _arrowNodes[i].transform.position - SkillTargeting.Transform.position));
            
               _arrowNodes[i].transform.rotation = Quaternion.Euler(euler);
            }

            //calculates scales for each arrow node
            var scale = scaleFactor * (1f - 0.03f * (_arrowNodes.Count - 1 - i));
               
            _arrowNodes[i].transform.localScale = new Vector3(scale, scale, 1f);
         }

         if (k != indexTracker)
         {
            SkillTargeting.SkillTargetingGameObjects.HideTargetNode(k);
         }
      }

   }


   private void ShowTargetCrossHair()
   {
      // ReSharper disable once PossibleNullReferenceException
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      //Store at most 5 ray cast hits
      var mResults = new RaycastHit[5];

      //ray traverses all layers
      var layerMask = ~0;

      //Same to RayCastAll but with no additional garbage
      int hitsCount = Physics.RaycastNonAlloc(ray, mResults, Mathf.Infinity, layerMask);

      //Update the latest targeted hero to null
      //_validSkillTargetHero = null;

      //SkillTargetCollider.Skill.CasterHero.HeroLogic.LastHeroTargets.SetTargetedHero(_validSkillTargetHero);

      //TODO: Hide target cross hair by default
      //SkillTargetCollider.Skill.SkillVisual.SkillGraphics.CrossHairGraphic.enabled = false;
      SkillTargeting.SkillTargetingGameObjects.CrossHair.GetComponent<Image>().enabled = false;

      for (int i = 0; i < hitsCount; i++)
      {
         if (mResults[i].transform.GetComponent<IHero>() != null)
         {
            var heroGameObject = mResults[i];
            var heroTarget = heroGameObject.transform.GetComponent<IHero>();

            //TODO: Get Valid Targets based on skill target (enemy or ally)
            var validHeroTargets = SkillTargeting.SkillTargets.GetValidTargets();

            //TODO: Check if the targeted hero is part of the valid targets before displaying the crosshair
            if (validHeroTargets.Contains(heroTarget))
            {
               //Display cross hair
               SkillTargeting.SkillTargetingGameObjects.ShowCrossHair();
                
               //Set cross hair position to position of target hero
               SkillTargeting.SkillTargetingGameObjects.CrossHair.gameObject.transform.position = heroTarget.Transform.position;
            }

            /*//TEMP
            //TODO: Display CrossHair
            SkillTargeting.SkillTargetingGameObjects.ShowCrossHair();

            //TODO: Transfer Crosshair transform to target
            SkillTargeting.SkillTargetingGameObjects.CrossHair.gameObject.transform.position = heroTarget.Transform.position;*/
            
           
         }
         else
         {
            //SkillTargeting.SkillTargetingCollider.HideCrossHair();
         }
      }

   }



   #endregion
}
