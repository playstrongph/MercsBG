using System.Collections.Generic;

public interface IHeroSkills
{
    IHero Hero { get; }

    int InUseHeroSkills { get; set; }
    List<ISkill> AllSkills { get; }
}