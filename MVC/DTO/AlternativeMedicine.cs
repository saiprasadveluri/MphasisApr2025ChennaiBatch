using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyApp.DTO
{
    public class GetAlternativeMedicine
    {
        public List<AlternativeMedicineDTO> data { get; set; }

    }
    public class AlternativeMedicine
    {
        [Key]
        public int alternativeId { get; set; }

        [ForeignKey(nameof(OriginalMedicine))]
        public int originalMedicineId { get; set; }

        [ForeignKey(nameof(SubstituteMedicine))]
        public int substituteMedicineId { get; set; }

        // Navigation
        public virtual Medicine OriginalMedicine { get; set; }
        public virtual Medicine SubstituteMedicine { get; set; }
    }
}
