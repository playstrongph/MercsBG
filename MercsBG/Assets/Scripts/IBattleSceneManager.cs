using SO_Assets;
using UnityEngine;

public interface IBattleSceneManager
{
    IBattleScene1SettingsAsset BattleScene1SettingsAsset { get; }
    IGameBoard GameBoard { get; }
    IPlayer MainPlayer { get; }
    IPlayer EnemyPlayer { get; }
    IHeroSkillsDisplay HeroSkillsDisplay { get; }
    IUsedSkillsHistory UsedSkillsHistory { get; }
    ICombatButton CombatButton { get; }
    ISkillTargetingCollider SkillTargetingCollider { get; }

    ISkillTargetingCollider DisplaySkillTargetingCollider { get; }

    IHeroPreview HeroPreview { get; }

    ISkillPreview SkillPreview { get; }

    IUsedSkillPreview UsedSkillPreview { get; }

    Transform Transform { get; }
    
    //Components
    IInitializePlayers InitializePlayers { get; }
    IInitializeHeroes InitializeHeroes { get; }

    IInitializeSkills InitializeSkills { get; }
}