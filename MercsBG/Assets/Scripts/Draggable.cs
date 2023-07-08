using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using Debug = System.Diagnostics.Debug;

public class Draggable : MonoBehaviour, IDraggable
{

      
    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
    
    
    
    private Vector3 _pointerDisplacement;
    private float _zDisplacement;
    private Camera _mainCamera;
    private Transform _originalTransform;
    private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;
    
    //TEST
    private delegate void SkillTargetingDelegate();

    private SkillTargetingDelegate _skillTargetingDelegate;

    private void Awake()
    {
        _mainCamera = Camera.main;
        
        //Initialize the method called in update to doing nothing
        _skillTargetingDelegate = NoAction;
    }
    
    /*private void OnEnable()
    {
        var thisPosition = this.transform.position;
        _zDisplacement = -_mainCamera.transform.position.z + thisPosition.z;
        _pointerDisplacement = -thisPosition + MouseInWorldCoords();
    }*/
    
    private void Update()
    {
        _skillTargetingDelegate();
    }

    private void ShowSkillTargeting()
    {
        var mousePos = MouseInWorldCoords();    
        var thisTransform = this.transform;
        thisTransform.position = new Vector3(mousePos.x - _pointerDisplacement.x, mousePos.y - _pointerDisplacement.y, thisTransform.position.z);
        SkillTargeting.ShowSkillTarget.ShowLineNodesArrowAndCrossHair();
    }

    private void NoAction()
    {
        
    }

    private Vector3 MouseInWorldCoords()
    {
        var screenMousePos = Input.mousePosition;
        screenMousePos.z = _zDisplacement;
        return _mainCamera.ScreenToWorldPoint(screenMousePos);
    }
        
    /// <summary>
    /// Enables draggable script
    /// specifically, the update method
    /// </summary>
    public void EnableDraggable()
    {
        this.enabled = true;
        
        //TEST
        var thisPosition = this.transform.position;
        _zDisplacement = -_mainCamera.transform.position.z + thisPosition.z;
        _pointerDisplacement = -thisPosition + MouseInWorldCoords();
        
        //assign the delegate method called in update to showSkillTargeting
        _skillTargetingDelegate = ShowSkillTargeting;
    }
        
    /// <summary>
    /// Disables the draggable script
    /// prevents the Update method from running continuously
    /// </summary>
    public void DisableDraggable()
    {
        
        //Assign the delegate method called in update to NoAction
        _skillTargetingDelegate = NoAction;

        this.enabled = false;
    }
    
    
    
}
