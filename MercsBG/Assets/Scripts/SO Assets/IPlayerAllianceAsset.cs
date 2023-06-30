namespace SO_Assets
{
    public interface IPlayerAllianceAsset
    {
        void ScaleUpHero(IHero hero);
        
        void ScaleDownHero(IHero hero);
        void DisplayHeroSkills(IHero hero);
    }
}