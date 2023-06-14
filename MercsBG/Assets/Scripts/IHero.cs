using UnityEngine;

public interface IHero
{

    IPlayer Player { get; }
    IHeroVisual HeroVisual { get; }

    IHeroSkills HeroSkills { get; }

    GameObject ThisGameObject { get; }

}