namespace MiniGameCollection;

public interface IMiniGame
{
    string Name { get; }
    string Description { get; }
    void Run();
}