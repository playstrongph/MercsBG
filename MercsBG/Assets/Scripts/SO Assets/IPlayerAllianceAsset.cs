namespace SO_Assets
{
    public interface IPlayerAllianceAsset
    {
        void UpdateHeroSkillsOnDisplay(IHeroSkills heroSkills, IPlayer player);
        void DisplaySkillsAndScaleUpHero(IHero hero);
    }
}