public interface IShowSkillsDisplay
{
    IHeroSkillsDisplay HeroSkillsDisplay { get; }
    void DisplayOn(IHero hero);
    void DisplayOff(IHero hero);
}