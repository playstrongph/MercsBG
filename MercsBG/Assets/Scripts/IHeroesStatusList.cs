using System.Collections.Generic;

public interface IHeroesStatusList
{
    List<IHero> AliveHeroesList { get; }
    List<IHero> DeadHeroesList { get; }
    List<IHero> ExtinctHeroesList { get; }
    
    
    
    void AddToAliveHeroList(IHero hero);
    void RemoveFromAliveHeroList(IHero hero);
    void AddToDeadHeroList(IHero hero);
    void RemoveFromDeadHeroList(IHero hero);
    void AddToExtinctHeroList(IHero hero);
    void RemoveFromExtinctHeroList(IHero hero);
}