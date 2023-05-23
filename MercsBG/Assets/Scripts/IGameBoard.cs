using UnityEngine;
using UnityEngine.UI;

public interface IGameBoard
{
    Canvas Canvas { get; }
    Image BoardImage { get; }
}