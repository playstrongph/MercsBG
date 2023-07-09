﻿using System.Collections.Generic;
using UnityEngine;

public interface ISkillTargetingCollider
{

    GameObject Arrow { get; }
    GameObject CrossHair { get; }
    List<GameObject> Nodes { get; }
    
    void ShowTargetArrow();
    void HideArrowAndNodes();
    void ShowCrossHair();
    void HideCrossHair();
}