using System.Collections.Generic;

namespace SO_Assets
{
    public interface ISkillTargetAsset
    {
        List<IHero> GetHeroTargets(IHero hero);

        /// <summary>
        /// Glow color is dependent on enemy type: Ally or Enemy
        /// </summary>
        void ShowTargetsGlow(IHero hero);

        /// <summary>
        /// Glow to be hidden is dependent on glow color that was shown
        /// </summary>
        void HideTargetsGlow(IHero hero);

        /// <summary>
        /// Resolve special circumstances in targeting
        /// </summary>
        /// <param name="hero"></param>
        void ResolveSpecialTargets(IHero hero);
    }
}