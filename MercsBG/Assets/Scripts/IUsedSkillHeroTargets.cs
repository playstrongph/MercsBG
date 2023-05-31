using System.Collections.Generic;
using UnityEngine;

public interface IUsedSkillHeroTargets
{
    List<IUsedSkillHeroTarget> HeroTargets { get; }
    Transform Transform { get; }
}