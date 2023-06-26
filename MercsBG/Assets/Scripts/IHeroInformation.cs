using SO_Assets;

public interface IHeroInformation
{
    string HeroName { get; set; }
    int HeroLevel { get; set; }
    int HeroStars { get; set; }
    int HeroCp { get; set; }

    /// <summary>
    /// Classes - Caster, Fighter, and Defender
    /// </summary>
    IHeroClassAsset HeroClass { get; set; }

    IHeroRaceAsset HeroRace { get; set; }
}