namespace SimpleGame.Domain.Model
{
    public interface IHouse
    {
        string Color { get; }
        int Level { get; }

        void LevelUp();

        void Paint(string color);
    }
}