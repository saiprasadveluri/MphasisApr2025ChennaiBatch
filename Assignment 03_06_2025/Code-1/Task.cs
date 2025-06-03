using System;
using System.Collections.Generic;

namespace TaskmanagerEFConsole;

public partial class Task
{
    public long TaskId { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long AssignedTo { get; set; }

    public string TaskType { get; set; } = null!;

    public DateOnly? StatDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public long TaskStatus { get; set; }

    public long ProjectId { get; set; }

    public virtual ProjectMember AssignedToNavigation { get; set; } = null!;

    public virtual Comment? Comment { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual TaskTypeMaster TaskStatusNavigation { get; set; } = null!;
}
