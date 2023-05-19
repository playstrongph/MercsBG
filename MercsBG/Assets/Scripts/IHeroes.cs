using System.Collections.Generic;

public interface IHeroes
{
    List<IHero> PlayerHeroes { get; }
    List<IHero> AliveHeroes { get; set; }
    List<IHero> DeadHeroes { get; set; }
    List<IHero> ExtinctHeroes { get; set; }
}