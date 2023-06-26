namespace SO_Assets
{
    public interface IHeroRaceAsset
    {
        string RaceName { get; }

        /// <summary>
        /// Set text of Hero Race in the hero preview
        /// </summary>
        /// <param name="hero"></param>
        void SetRace(IHero hero);
    }
}