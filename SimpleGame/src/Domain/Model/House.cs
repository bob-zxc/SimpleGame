namespace SimpleGame.Domain.Model
{
    public class House : IHouse
    {
        public string Color { get; private set; }

        public int Level { get; private set; }

        public House(string color, int level)
        {
            Color = color;
            Level = level;
        }

        public void LevelUp()
        {
            Level++;
        }

        public void Paint(string color)
        {
            Color = color;
        }
    }
}