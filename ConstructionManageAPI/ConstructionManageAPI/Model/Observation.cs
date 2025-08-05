using System.ComponentModel.DataAnnotations;

namespace ConstructionManageAPI.Model
{
    public class Observation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ConstructionRecord>? Datas { get; set; } 
    }
}
