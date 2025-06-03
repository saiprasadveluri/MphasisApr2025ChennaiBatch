using System;
using System.Collections.Generic;

namespace TaskmanagerEFConsole;

public partial class ProjectMember
{
    public long MemberId { get; set; }

    public long ProjId { get; set; }

    public long UserId { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual Project Proj { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual UserInfo User { get; set; } = null!;
}
