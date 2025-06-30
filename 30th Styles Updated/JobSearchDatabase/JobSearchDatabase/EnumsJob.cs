using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchDatabase
{
    public class EnumsJob
    {

        public enum JobCategoryName
        {
            InformationTechnology,
            Finance,
            Healthcare,
            Education,
            Engineering,
            Marketing,
            Other
        }
        public enum EmploymentType
        {
            FullTime,
            PartTime,
            Contract,
            Guidernship,
            Freelance,
            Temporary,
            Other
        }
        public enum JobStatus
        {
            Open,
            Closed,
            Pending,
            Cancelled,
            InReview,
            Filled
        }
        public enum FieldOfStudy
        {
            ComputerScience,
            MechanicalEngineering,
            ElectricalEngineering,
            BusinessAdministration,
            Economics,
            Psychology,
            Biology,
            Literature,
            Mathematics,
            Other
        }

        public enum Degree
        {
            HighSchool,
            Diploma,
            Associate,
            Bachelors,
            Masters,
            Doctorate,
            Professional,
            Other
        }



        public enum SkillLevel { Beginner, Guidermediate, Expert }
        


    }
}
