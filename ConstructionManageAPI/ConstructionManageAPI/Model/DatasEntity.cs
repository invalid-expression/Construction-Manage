using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ConstructionManageAPI.Model
{
    public class DatasEntity
    {
        [Key]
        [JsonIgnore]
        public int ID { get; set; }

        public DateTime SamplingTime { get; set; }

        [JsonIgnore]
        public int ObservationEntityID { get; set; }

        [JsonIgnore]
        [ForeignKey("ObservationEntityID")]
        public ObservationEntity? ObservationEntity { get; set; }

        public List<PropertyEntity>? PropertyEntities { get; set; }
    }
}
