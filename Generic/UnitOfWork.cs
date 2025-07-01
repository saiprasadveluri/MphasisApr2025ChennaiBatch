using JobSearchMVC.DataDTO;

namespace JobSearchMVC.Models
{
    public class UnitOfWork
    {
        public readonly GenericRepositoryMVC<UserDTO> userRepository;
        public readonly UserMVCRepo userMVCRepo;
        public readonly GenericRepositoryMVC<WorkExperienceDTO> workRepo;
        public readonly GenericRepositoryMVC<CandidateDTO> candidateRepo;
        public readonly GenericRepositoryMVC<EmployerDTO> employerRepo;
        public readonly GenericRepositoryMVC<EducationDTO> educationRepo;
        public readonly GenericRepositoryMVC<WorkExperienceDTO> workexpRepo;
        public UnitOfWork(HttpClient httpClient)
        {
            // You can define the endpoint segments here
            userMVCRepo = new UserMVCRepo(httpClient);
            userRepository = new GenericRepositoryMVC<UserDTO>(httpClient, "User");
            workRepo = new GenericRepositoryMVC<WorkExperienceDTO>(httpClient, "WorkExperience");
            candidateRepo = new GenericRepositoryMVC<CandidateDTO>(httpClient, "Candidates");
            employerRepo = new GenericRepositoryMVC<EmployerDTO>(httpClient, "Employer");
            educationRepo = new GenericRepositoryMVC<EducationDTO>(httpClient, "Education");
            workexpRepo = new GenericRepositoryMVC<WorkExperienceDTO>(httpClient, "WorkExperience");
        }

    }
}