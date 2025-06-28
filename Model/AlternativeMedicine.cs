using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyAppAPI.Model
{
    public class AlternativeMedicine
    {
        [Key]
        public int AlternativeId { get; set; }

        [ForeignKey(nameof(OriginalMedicine))]
        public int OriginalMedicineId { get; set; }

        [ForeignKey(nameof(SubstituteMedicine))]
        public int SubstituteMedicineId { get; set; }

        // Navigation
        public virtual Medicine OriginalMedicine { get; set; }
        public virtual Medicine SubstituteMedicine { get; set; }
    }
}
