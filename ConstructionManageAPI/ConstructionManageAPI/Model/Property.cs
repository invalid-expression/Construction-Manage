using System.ComponentModel.DataAnnotations;

namespace ConstructionManageAPI.Model
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public int ConstructionRecordId { get; set; }  // Foreign key
        public string Label { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
