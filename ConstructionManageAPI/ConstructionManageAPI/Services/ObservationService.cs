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
        public async Task<IEnumerable<ObservationEntity>> GetObservation()
        {
            var Data = await _context.ObservationEntity
                .Select(x => new ObservationEntity
                {
                    ID = x.ID,
                    Name = x.Name,
                    ConstructionRecordEntities = x.ConstructionRecordEntities
                    .Select(y => new DatasEntity
                    {
                        SamplingTime = y.SamplingTime,
                        PropertyEntities = y.PropertyEntities
                        .Select(z => new PropertyEntity
                        {
                            Label = z.Label,
                            Value = z.Value
                        }).ToList()
                    }).ToList(),
                }).ToListAsync();

            return Data;
        }
    }
}
