using UnityEngine;

namespace SO_Assets
{
    public interface ISkillEnableStatusAsset
    {
        void EnableTargetVisuals(Transform transform, ISkillVisualCollider skillVisualCollider);

        /// <summary>
        /// Verification that skill is enabled before setting the valid target hero
        /// after mouse up in manual/auto select target scripts
        /// </summary>
        /// <param name="skill"></param>
        void SelectTarget(ISkill skill);

        void DisableTargetVisuals(ISkill skill);

        /// <summary>
        /// This is the "X" icon 
        /// </summary>
        /// <param name="skill"></param>
        void SkillDisabledVisuals(ISkill skill);

        /// <summary>
        /// Select skill for active and basic skills
        /// </summary>
        /// <param name="skillVisualCollider"></param>
        void ManualSelectSkill(ISkillVisualCollider skillVisualCollider);

        void SelectSkillTarget(ISelectSkillTarget selectSkillTarget);
    }
}