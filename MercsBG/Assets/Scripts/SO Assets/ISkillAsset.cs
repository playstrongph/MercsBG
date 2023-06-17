using UnityEngine;

namespace SO_Assets
{
    public interface ISkillAsset
    {
        string SkillName { get; }
        string SkillDescription { get; }
        Sprite SkillSprite { get; }
        int SkillCooldown { get; }
        int SkillSpeed { get; }
        int FightingSpirit { get; }

        ISkillElementAsset SkillElement { get; }
        ISkillTypeAsset SkillType { get; }

        ISkillTargetAsset SkillTarget { get; }
        ISkillReadinessAsset SkillReadiness { get; }
    }
}