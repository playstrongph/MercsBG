using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDisplaySkillTargeting : MonoBehaviour
{
   #region VARIABLES

   [Header("Inspector References")]
   [SerializeField] [RequireInterfaceAttribute.RequireInterface(typeof(IDisplaySkillTargeting))] private Object displaySkillTargeting = null;
        

   #endregion
        
   #region PROPERTIES

   private IDisplaySkillTargeting DisplaySkillTargeting => displaySkillTargeting as IDisplaySkillTargeting;     
   
   #endregion
        
   #region METHODS
   
   //TODO - Draw the target arrow

   #endregion
}
