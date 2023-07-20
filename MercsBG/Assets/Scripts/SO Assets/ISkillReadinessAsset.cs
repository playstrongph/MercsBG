using UnityEngine;

namespace SO_Assets
{
    public interface ISkillReadinessAsset
    {
        void LoadSkillReadinessVisuals(ISkill skill);

        /// <summary>
        /// Enable skill targeting when skill is NOT disabled and skill is ready
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="skillVisualCollider"></param>
        void EnableTargetVisuals(Transform transform, ISkillVisualCollider skillVisualCollider);

        /// <summary>
        /// Used in verifying if skill is ready and enabled
        /// </summary>
        /// <param name="skill"></param>
        void SelectTarget(ISkill skill);

        void DisableTargetVisuals(ISkill skill);
        
        /// <summary>
        /// Active and Basic skill select
        /// </summary>
        /// <param name="skillVisualCollider"></param>
        void ManualSelectSkill(ISkillVisualCollider skillVisualCollider);

        void SelectSkillTarget(ISelectSkillTarget selectSkillTarget);
    }
}