using System.Collections.Generic;

public interface IHeroPreview
{
    IBattleSceneManager BattleSceneManager { get; }
    IHeroPreviewHero HeroPreviewHero { get; }
    List<IHeroPreviewSkill> HeroPreviewSkills { get; }
}