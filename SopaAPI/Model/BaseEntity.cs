using System.ComponentModel.DataAnnotations;

namespace SopaAPI.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
