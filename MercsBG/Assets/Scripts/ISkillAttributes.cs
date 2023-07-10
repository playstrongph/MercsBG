using SO_Assets;
using UnityEngine;

public interface ISkillAttributes
{
    string SkillName { get; set; }
    string Description { get; set; }
    int SkillCooldown { get; set; }
    int SkillSpeed { get; set; }
    int FightingSpirit { get; set; }
    int BaseSkillCooldown { get; set; }
    int BaseSkillSpeed { get; set; }
    Sprite SkillSprite { get; set; }

    ISkillElementAsset SkillElement { get; set; }
    ISkillTypeAsset SkillType { get; set; }
    ISkillTargetAsset SkillTarget { get; set; }
    ISkillReadinessAsset SkillReadiness { get; set; }
    ISkillEnableStatusAsset SkillEnableStatus { get; set; }
}