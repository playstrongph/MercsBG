using UnityEngine;

public interface ICombatButton
{
    void SetButtonText(string text);
    void SetGreyButton();
    void SetGreenButton();
    void SetYellowButton();
    Canvas Canvas { get; }
}