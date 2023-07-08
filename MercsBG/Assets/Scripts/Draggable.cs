using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Debug = System.Diagnostics.Debug;

public class Draggable : MonoBehaviour, IDraggable
{
    //VARIABLES

    [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(ISkillTargeting))] private Object skillTargeting = null;
    
    private Vector3 _pointerDisplacement;
    private float _zDisplacement;
    private Camera _mainCamera;
    
    //Delegate Update Method
    private delegate void ShowSkillTargeting();
    private ShowSkillTargeting _skillTargeting;


    //PROPERTIES
    private ISkillTargeting SkillTargeting => skillTargeting as ISkillTargeting;
    
    
    

    private void Awake()
    {
        _mainCamera = Camera.main;
        _skillTargeting = NoAction;
    }
    
    private void OnEnable()
    {
        
        var thisPosition = this.transform.position;
        _zDisplacement = -_mainCamera.transform.position.z + thisPosition.z;
        _pointerDisplacement = -thisPosition + MouseInWorldCoords();
    }
    
    private void Update()
    {
        _skillTargeting();
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
        _skillTargeting = UpdateAction;
    }
        
    /// <summary>
    /// Disables the draggable script
    /// prevents the Update method from running continuously
    /// </summary>
    public void DisableDraggable()
    {
        _skillTargeting = NoAction;
        this.enabled = false;
    }

    private void UpdateAction()
    {
        var mousePos = MouseInWorldCoords();    
        var thisTransform = this.transform;
            
        thisTransform.position = new Vector3(mousePos.x - _pointerDisplacement.x, mousePos.y - _pointerDisplacement.y, thisTransform.position.z);
            
        //SkillTargetCollider.SkillTargetDisplay.ShowLineArrowAndCrossHair();
    }

    private void NoAction()
    {
        
    }
}
