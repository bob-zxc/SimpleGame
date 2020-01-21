using SimpleGame.Domain.Model;

namespace SimpleGame.Domain.Factory
{
    public class HouseFactory : IHouseFactory
    {
        public IHouse CreateInitialHouse()
        {
            return new House("White", 0);
        }
    }
}