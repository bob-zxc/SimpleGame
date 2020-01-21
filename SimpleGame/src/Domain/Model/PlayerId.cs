namespace SimpleGame.Domain.Model
{
    public class PlayerId : IPlayerId
    {
        public string Id { get; }

        public PlayerId(string id)
        {
            Id = id;
        }
    }
}