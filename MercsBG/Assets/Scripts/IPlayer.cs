public interface IPlayer
{
    IBattleSceneManager BattleSceneManager { get; }
    IPlayer OtherPlayer { get; set; }
    IHeroes Heroes { get; }
}