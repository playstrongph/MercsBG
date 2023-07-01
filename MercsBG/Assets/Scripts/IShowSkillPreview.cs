public interface IShowSkillPreview
{
    ISkillPreview SkillPreview { get; }
    void TurnOn(ISkill skill);

    void TurnOnAtMouseEnter(ISkill skill);
    void TurnOff();

    void TurnOffAtMouseExit();


}