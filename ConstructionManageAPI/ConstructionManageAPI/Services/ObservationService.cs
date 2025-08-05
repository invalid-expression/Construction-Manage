using ConstructionManageAPI.Context;
using ConstructionManageAPI.Interface;
using ConstructionManageAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ConstructionManageAPI.Services
{
    public class ObservationService : IObservation
    {
        private readonly ApplicationContext _context;
        public ObservationService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Observation>> GetObservation()
        {
            var Data = await _context.Observations.Include(o => o.Datas).ThenInclude(d => d.Properties).ToListAsync();
            return Data;
        }
    }
}
