using System.Collections.Generic;

public interface IHeroSkills
{
    IHero CasterHero { get; }

    int InUseHeroSkills { get; set; }
    List<ISkill> AllSkills { get; }

    IHero SelectedTargetHero { get; set; }

    ISkill SelectedCastingSkill { get; set; }
}