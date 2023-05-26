using System.Collections.Generic;
using UnityEngine;

public interface IHeroPreview
{
    IBattleSceneManager BattleSceneManager { get; }
    IHeroPreviewHero HeroPreviewHero { get; }
    List<IHeroPreviewSkill> HeroPreviewSkills { get; }

    Canvas Canvas { get; }
}