using UnityEngine;

public interface IStatusEffect
{
    Canvas Canvas { get; }
    void SetFrame(Sprite newFrame);
    void SetIcon(Sprite newIcon);
    void SetCounters(int newCounters);
}