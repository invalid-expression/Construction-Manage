using ConstructionManageAPI.Model;

namespace ConstructionManageAPI.Interface
{
    public interface IObservation
    {
        Task<IEnumerable<Observation>> GetObservation();
    }
}
