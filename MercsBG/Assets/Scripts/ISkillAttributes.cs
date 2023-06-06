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
}