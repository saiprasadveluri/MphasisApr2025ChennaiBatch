using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchAPI.DataDTO
{
    public class EnumsJob
    {

        public enum JobCategoryName
        {
            InformationTechnology = 11,
            Finance,
            Healthcare,
            Education,
            Engineering,
            Marketing,
            Other
        }
        public enum EmploymentType
        {
            FullTime = 21,
            PartTime,
            Contract,
            Guidernship,
            Freelance,
            Temporary,
            Other
        }
        public enum JobStatus
        {
            Open = 31,
            Closed,
            Pending,
            Cancelled,
            InReview,
            Filled
        }
        public enum FieldOfStudy
        {
            ComputerScience = 41,
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
            HighSchool = 51,
            Diploma,
            Associate,
            Bachelors,
            Masters,
            Doctorate,
            Professional,
            Other
        }

        public enum SkillLevel 
        { 
            Beginner = 1, 
            Guidermediate, 
            Expert }
        


    }
}
