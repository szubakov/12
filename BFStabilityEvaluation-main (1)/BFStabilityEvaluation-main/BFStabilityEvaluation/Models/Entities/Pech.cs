using System.ComponentModel.DataAnnotations;

namespace BFStabilityEvaluation.Models.Entities
{
    public class Pech
    {
        [Key]
        public int NPech { get; set; }

        [StringLength(128)]
        public string Name { get; set; }
    }
}
