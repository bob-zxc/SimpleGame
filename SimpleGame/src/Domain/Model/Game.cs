namespace SimpleGame.Domain.Model
{
    public class Game : IGame
    {
        public IPlayerId PlayerId { get; }

        public IHouse House { get; }

        public Game(
            IPlayerId playerId, 
            IHouse house
        )
        {
            PlayerId = playerId;
            House = house;
        }

        public void LevelUp()
        {
            House.LevelUp();
        }

        public void Paint(string color)
        {
            House.Paint(color);
        }
    }
}