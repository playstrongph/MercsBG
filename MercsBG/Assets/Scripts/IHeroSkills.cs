using System.Collections.Generic;

public interface IHeroSkills
{
    IHero Hero { get; }
    List<ISkill> AllSkills { get; }
}