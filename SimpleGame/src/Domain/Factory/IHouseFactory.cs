using SimpleGame.Domain.Model;

namespace SimpleGame.Domain.Factory
{
    public interface IHouseFactory
    {
        IHouse CreateInitialHouse();
    }
}