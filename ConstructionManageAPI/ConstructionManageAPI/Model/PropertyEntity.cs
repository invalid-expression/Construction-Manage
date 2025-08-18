using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ConstructionManageAPI.Model
{
    public class PropertyEntity
    {
        [Key]
        [JsonIgnore]
        public int ID { get; set; }

        public string Label { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;

        [JsonIgnore]
        public int DatasID { get; set; }

        [JsonIgnore]
        [ForeignKey("DatasID")]
        public DatasEntity? DatasEntity { get; set; }
    }
}
