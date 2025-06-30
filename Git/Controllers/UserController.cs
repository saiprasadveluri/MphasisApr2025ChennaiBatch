using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Services.UserAccountMapping;
using static JobSearchAPI.DataDTO.UserCandEmp;

namespace JobSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UnitOfWork _uow;
        private readonly IPasswordHasher<UserDTO> _hasher;


        public UserController(UnitOfWork uow,IPasswordHasher<UserDTO> hasher)
        {
            _uow = uow;
            _hasher = hasher;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetAllUsers()
        {
            var users = _uow.UserRepo.GetAll();
            return Ok(users);
        }
        
        [HttpPost("register")]
            public IActionResult Register([FromBody] UserCandEmp request)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = new UserCandEmp
                {
                    UserId = Guid.NewGuid(),
                    UserName = request.UserName,
                    Password = _hasher.HashPassword(null!, request.Password),
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                    IsActive = true,
                    UserRole = request.UserRole
                };

                if (request.UserRole == "Candidate")
                {
                    if (request.Candidate is null)
                        return BadRequest("Candidate details required for role=Candidate.");

                    user.Candidate = new Candidates
                    {
                        CandidateId = Guid.NewGuid(),
                        UserId = user.UserId,
                        FirstName = request.Candidate.FirstName,
                        LastName = request.Candidate.LastName,
                        DateOfBirth = request.Candidate.DateOfBirth,
                        Gender = request.Candidate.Gender,
                        Address = request.Candidate.Address,
                        ResumeFilePath = request.Candidate.ResumeFilePath!,
                        ProfileSummary = request.Candidate.ProfileSummary!
                    };
                }
                else
                {
                    if (request.Employer is null)
                        return BadRequest("Employer details required for role=Employer.");

                    user.Employer = new Employers
                    {
                        EmployerId = Guid.NewGuid(),
                        UserId = user.UserId,
                        CompanyName = request.Employer.CompanyName,
                        CompanyDescription = request.Employer.CompanyDescription,
                        WebsiteUrl = request.Employer.WebsiteUrl,
                        EmployerName = request.Employer.EmployerName,
                        Designation = request.Employer.Designation
                    };
                }
                _uow.UserRepo.Insert(user);
                _uow.Save();

                return Ok(user);
            }

            //[HttpGet("{id:guid}")]
            //public IActionResult GetByWithId(Guid id)
            //{
            //    var user = _uow.UserRepo
            //                   .GetAll(u => u.UserRole != default) 
            //                   .SingleOrDefault(u => u.UserId == id);

            //    if (user is null)
            //        return NotFound($"No user with ID {id}.");

            //    var dto = new
            //    {
            //        user.UserId,
            //        user.UserName,
            //        user.Email,
            //        user.PhoneNumber,
            //        user.RegistrationDate,
            //        user.IsActive,
            //        user.UserRole,
            //        Candidate = user.Candidate is null
            //                    ? null
            //                    : new
            //                    {
            //                        user.Candidate.FirstName,
            //                        user.Candidate.LastName,
            //                        user.Candidate.DateOfBirth,
            //                        user.Candidate.Gender,
            //                        user.Candidate.Address,
            //                        user.Candidate.ResumePath,
            //                        user.Candidate.Summary
            //                    },
            //        Employer = user.Employer is null
            //                   ? null
            //                   : new
            //                   {
            //                       user.Employer.CompanyName,
            //                       user.Employer.CompanyDescription,
            //                       user.Employer.WebsiteUrl,
            //                       user.Employer.ContactName,
            //                       user.Employer.Designation
            //                   }
            //    };

            //    return Ok(dto);
            //}
        

        [HttpPost]
        public ActionResult<UserDTO> CreateUser(UserDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _uow.UserRepo.Insert(dto);
            _uow.Save();

            return CreatedAtAction(nameof(GetAllUsers), new { id = dto.UserId }, dto);
        }
        [HttpGet("{id}")]
        public ActionResult<UserDTO> ByGetId(Guid id)
        {
            var user = _uow.UserRepo.GetById(id);


            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public ActionResult<UserDTO> UpdateUser(Guid id, UserDTO updatedUser)
        {
            var userup = _uow.UserRepo.UpdateById(id, updatedUser);
            _uow.Save();
            return Ok(userup);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            var user = _uow.UserRepo.DeleteById(id);
            _uow.Save();
            return Ok(user);
        }
    }
}

