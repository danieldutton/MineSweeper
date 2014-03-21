namespace Swinesweeper.GameModeFactory.Interfaces
{
    public interface IGameModeFactory
    {
        IGameMode CreateInstance(string gameModeName);
    }
}
