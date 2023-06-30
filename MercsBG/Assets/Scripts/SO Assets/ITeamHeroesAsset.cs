using System.Collections.Generic;

namespace SO_Assets
{
    public interface ITeamHeroesAsset
    {
        List<IHeroAsset> HeroAssets { get; }

        IPlayerAllianceAsset PlayerAlliance { get; }
    }
}