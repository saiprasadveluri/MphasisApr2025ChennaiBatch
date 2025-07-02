using JobSearchDatabase.Data;


namespace JobSearchDatabase.Models
{
    public class UnitOfWorkDb
    {
        public readonly GenericRepositoryMVC<User> userRepository;
        public readonly UserMVCRepo userMVCRepo;
        public readonly GenericRepositoryMVC<WorkExperience> workRepo;
        public readonly GenericRepositoryMVC<Candidate> candidateRepo;
        public readonly GenericRepositoryMVC<Employer> employerRepo;
        public readonly GenericRepositoryMVC<Education> educationRepo;
        public readonly GenericRepositoryMVC<CandidateSkills> candidateSkillsRepo;
        public readonly GenericRepositoryMVC<Skill> skillRepo;
        public readonly GenericRepositoryMVC<JobApplicationDTO> jobApplicationRepo;
        public readonly GenericRepositoryMVC<JobPosting> jobPostingRepo;
        public readonly GenericRepositoryMVC<JobCategory> jobCategoryRepo;
        public UnitOfWorkDb(HttpClient httpClient)
        {
            userMVCRepo = new UserMVCRepo(httpClient);
            userRepository = new GenericRepositoryMVC<User>(httpClient, "User");
            workRepo = new GenericRepositoryMVC<WorkExperience>(httpClient, "WorkExperience");
            candidateRepo = new GenericRepositoryMVC<Candidate>(httpClient, "Candidates");
            employerRepo = new GenericRepositoryMVC<Employer>(httpClient, "Employer");
            educationRepo = new GenericRepositoryMVC<Education>(httpClient, "Education");
            candidateSkillsRepo = new GenericRepositoryMVC<CandidateSkills>(httpClient, "CandidateSkills");
            skillRepo = new GenericRepositoryMVC<Skill>(httpClient, "Skill");
            jobApplicationRepo = new GenericRepositoryMVC<JobApplicationDTO>(httpClient, "JobApplication");
            jobPostingRepo = new GenericRepositoryMVC<JobPosting>(httpClient, "JobPosting");
            jobCategoryRepo = new GenericRepositoryMVC<JobCategory>(httpClient, "JobCategory");
        }


    }
}