using System.ComponentModel.DataAnnotations;

namespace ConstructionManageAPI.Model
{
    public class ObservationEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<DatasEntity>? Datas { get; set; }      
    }
}