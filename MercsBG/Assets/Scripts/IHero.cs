using UnityEngine;

public interface IHero
{
    IPlayer Player { get; }
    IHeroSkills HeroSkills { get; }
    GameObject ThisGameObject { get; }

    IHeroInformation HeroInformation { get; }
    IHeroAttributes HeroAttributes { get; }
    IHeroVisual HeroVisual { get; }

    Transform Transform { get; }

}