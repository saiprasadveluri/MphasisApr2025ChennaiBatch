using System;
using System.Collections.Generic;

namespace TaskmanagerEFConsole;

public partial class TaskTypeMaster
{
    public long TaskTypeId { get; set; }

    public string TaskTypeName { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
