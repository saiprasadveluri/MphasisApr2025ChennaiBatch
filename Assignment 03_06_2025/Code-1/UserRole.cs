using System;
using System.Collections.Generic;

namespace TaskmanagerEFConsole;

public partial class UserRole
{
    public long RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserInfo> UserInfos { get; set; } = new List<UserInfo>();
}
