﻿using System.Collections.Generic;
using UnityEngine;

public interface ISkillVisuals
{
    List<ISkillVisual> HeroSkillVisuals { get; }

    ISkillPanelFrames SkillPanelFrames { get; }

    Transform Transform { get; }

    IHeroSkillsDisplay HeroSkillsDisplay { get; }
    
    



}