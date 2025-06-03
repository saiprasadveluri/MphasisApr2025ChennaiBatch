using System;
using System.Collections.Generic;

namespace TaskmanagerEFConsole;

public partial class UserInfo
{
    public long UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long Role { get; set; }

    public string Phone { get; set; } = null!;

    public virtual ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();

    public virtual UserRole RoleNavigation { get; set; } = null!;
}
