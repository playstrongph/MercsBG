public interface ISkillTargeting
{
    ISkillTargetingCollider SkillTargetingCollider { get; }
    IDraggable Draggable { get; }
    IShowSkillTarget ShowSkillTarget { get; }

    IHeroSkillsDisplay HeroSkillsDisplay { get; }
}