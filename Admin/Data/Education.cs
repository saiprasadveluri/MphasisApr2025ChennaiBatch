using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobSearchDatabase.EnumsJob;

namespace JobSearchDatabase.Data
{
    public class Education
    {
        [Key]
        public Guid EducationId { get; set; }
        public Guid CandidateId { get; set; }
        public string? Institution { get; set; }
        [Range((int)Degree.HighSchool, (int)Degree.Other)]
        public Degree Degree { get; set; }
        [Range((int)FieldOfStudy.ComputerScience, (int)FieldOfStudy.Other)]
        public FieldOfStudy FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }

    }
}
