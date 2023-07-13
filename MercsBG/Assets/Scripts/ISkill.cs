public interface ISkill
{
    ISkillAttributes SkillAttributes { get; }
    IHeroSkills HeroSkills { get; }

    IHero CasterHero { get; }

}