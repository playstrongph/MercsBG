using System.Collections.Generic;
using UnityEngine;

public interface ISkillTargetingGameObjects
{

    GameObject Arrow { get; }
    GameObject CrossHair { get; }
    List<GameObject> Nodes { get; }
    
    void ShowTargetArrow();
    void HideArrowAndNodes();
    void ShowCrossHair();
    void HideCrossHair();

    void HideTargetNode(int index);
        
    void ShowTargetNode(int index);
}