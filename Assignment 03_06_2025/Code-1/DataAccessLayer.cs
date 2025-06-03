using System.Runtime.CompilerServices;
using TaskmanagerEFConsole;

public class DataAccess
{
    MphTaskManagerDbContext _context;
    public DataAccess()
    {
        _context = new MphTaskManagerDbContext();
    }

    public (UserInfo, bool) ValidateUser(string Email, string Password)
    {
        UserInfo userInfo = _context.UserInfos.
        FirstOrDefault(u => u.Email == Email && u.Password == Password);
        if (userInfo == null)
        {
            return (null, false);
        }
        else
        {
            return (userInfo, true);
        }
    }
    public bool IsEmailExists(string email)
    {
        UserInfo UserWithEmail = _context.UserInfos.FirstOrDefault(u => u.Email == email);
        return UserWithEmail != null;
    }

    public bool IsInRole(string Email, long ReqRole)
    {
        UserInfo selUser = _context.UserInfos.FirstOrDefault(u => u.Email == Email);
        if (selUser != null)
        {
            if (selUser.Role == ReqRole)
            {
                return true;
            }
        }
        return false;
    }
    public bool AddNewUser(string Name, string Password, string Email, string Phone, long RoleId)
    {
        UserInfo userInfo = new UserInfo()
        {
            Name = Name,
            Password = Password,
            Email = Email,
            Phone = Phone,
            Role = RoleId
        };
        _context.UserInfos.Add(userInfo);
        int Entries = _context.SaveChanges();
        return Entries != 0;
    }

    public bool AddProject(string ProjectTitle, string ProjectDescription,
    DateOnly StartDate, DateOnly EndDate)
    {
        Project project = new Project()
        {
            Title = ProjectTitle,
            Description = ProjectDescription,
            StartDate = StartDate,
            EndDate = EndDate
        };
        _context.Projects.Add(project);
        int Entries = _context.SaveChanges();
        return Entries != 0;
    }
   
}