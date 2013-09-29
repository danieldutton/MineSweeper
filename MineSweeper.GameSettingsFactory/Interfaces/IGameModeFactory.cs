namespace MineSweeper.GameModeFactory.Interfaces
{
    public interface IGameModeFactory
    {
        IGameMode CreateInstance(string gameModeName);
    }
}
