using JobSearchAPI.DataDTO;

namespace JobSearchAPI.DAL
{
    public class UnitOfWork : IDisposable
    {
        private JSDbContextAPI context ;
        private GenericRepository<UserDTO> userRepo;
        private GenericRepository<SkillDTO> skillRepo;
        private GenericRepository<CandidateDTO> candRepo;
        private GenericRepository<CandidateSkillsDTO> candskillRepo;
        private GenericRepository<EducationDTO> educationRepo;
        private GenericRepository<EmployerDTO> employerRepo;
        private GenericRepository<JobApplicationDTO> applicationRepo;
        private GenericRepository<JobPostingDTO> jobPostingRepo;
        private GenericRepository<JobCategoryDTO> categoryRepo;
        public GenericRepository<WorkExperienceDTO> workExperienceRepo;
        private bool disposedValue = false;

        public UnitOfWork(JSDbContextAPI _context)
        {
            context = _context;
        }

        public GenericRepository<UserDTO> UserRepo
        {
            get
            {
                if (userRepo == null)
                {
                    userRepo = new GenericRepository<UserDTO>(context);
                }
                return userRepo;
            }
        }
        public GenericRepository<SkillDTO> SkillRepo
        {
            get
            {
                if (skillRepo == null)
                {
                    skillRepo = new GenericRepository<SkillDTO>(context);
                }
                return skillRepo;
            }
        }
        public GenericRepository<CandidateDTO> CandRepo
        {
            get
            {
                if (candRepo == null)
                {
                    candRepo = new GenericRepository<CandidateDTO>(context);
                }
                return candRepo;
            }
        }
        public GenericRepository<CandidateSkillsDTO> CandSkillRepo
        {
            get
            {
                if (candskillRepo == null)
                {
                    candskillRepo = new GenericRepository<CandidateSkillsDTO>(context);
                }
                return candskillRepo;
            }
        }
        public GenericRepository<EducationDTO> EducationRepo
        {
            get
            {
                if (educationRepo == null)
                {
                    educationRepo = new GenericRepository<EducationDTO>(context);
                }
                return educationRepo;
            }
        }
        public GenericRepository<EmployerDTO> EmployerRepo
        {
            get
            {
                if (employerRepo == null)
                {
                    employerRepo = new GenericRepository<EmployerDTO>(context);
                }
                return employerRepo;
            }
        }
        public GenericRepository<JobApplicationDTO> ApplicationRepo
        {
            get
            {
                if (applicationRepo == null)
                {
                    applicationRepo = new GenericRepository<JobApplicationDTO>(context);
                }
                return applicationRepo;
            }
        }
        public GenericRepository<JobCategoryDTO> CategoryRepo
        {
            get
            {
                if (categoryRepo == null)
                {
                    categoryRepo = new GenericRepository<JobCategoryDTO>(context);
                }
                return categoryRepo;
            }
        }
        public GenericRepository<JobPostingDTO> JobPostingRepo
        {
            get
            {
                if (jobPostingRepo == null)
                {
                    jobPostingRepo = new GenericRepository<JobPostingDTO>(context);
                }
                return jobPostingRepo;
            }
        }
        public GenericRepository<WorkExperienceDTO> WorkExperienceRepo
        {
            get
            {
                if (workExperienceRepo == null)
                {
                    workExperienceRepo = new GenericRepository<WorkExperienceDTO>(context);
                }
                return workExperienceRepo;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
