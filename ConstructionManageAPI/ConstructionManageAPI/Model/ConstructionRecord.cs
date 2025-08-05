using System.ComponentModel.DataAnnotations;

namespace ConstructionManageAPI.Model
{
    public class ConstructionRecord
    {
        [Key]
        public int Id { get; set; }
        public int ObservationId { get; set; }  
        public DateTime SamplingTime { get; set; }
        public List<Property>? Properties { get; set; }
    }
}
