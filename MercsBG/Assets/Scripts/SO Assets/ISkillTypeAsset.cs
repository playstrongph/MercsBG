using TMPro;
using UnityEngine.UI;

namespace SO_Assets
{
    public interface ISkillTypeAsset
    {
        void LoadSkillTypeVisuals(ISkill skill);
        void SelectTarget(ISkill skill);
        void DisableTargetVisuals(ISkill skill);
        void EnableSkillTargeting(ISkill skill);
        void SetSkillFrame(ISkillVisual skillVisual, int skillCooldown);

        void SetCooldownGraphicAndText(Image image, TextMeshProUGUI cooldownText, int cooldown);

        void SetSpeedGraphicAndText(Image image, TextMeshProUGUI speedText, int speed);

        void SelectSkillActions(ISkillTargetCollider skillTargetCollider);
    }
}