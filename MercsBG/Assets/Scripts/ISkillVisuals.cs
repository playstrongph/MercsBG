using System.Collections.Generic;
using UnityEngine;

public interface ISkillVisuals
{
    List<ISkillVisual> HeroSkillVisuals { get; }

    Transform Transform { get; }

}