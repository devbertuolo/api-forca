using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table("PALAVRAS")]
    public class Palavra
    {
        [Key]
        public int id { get; set; } 

        [Required]
        [MaxLength(100)]
        public string palavra { get; set; } = string.Empty; 

        [Required]
        [MaxLength(50)]
        public string categoria { get; set; } = string.Empty; 
    }
}