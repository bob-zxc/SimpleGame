namespace SimpleGame.Domain.Model
{
    public interface IGame
    {
        IPlayerId PlayerId { get; }
        
        IHouse House { get; }
        void LevelUp();
        void Paint(string color);
    }
}