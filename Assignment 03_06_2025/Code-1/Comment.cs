using System;
using System.Collections.Generic;

namespace TaskmanagerEFConsole;

public partial class Comment
{
    public long CommentId { get; set; }

    public long ParentTaskId { get; set; }

    public string Title { get; set; } = null!;

    public string TaskDescription { get; set; } = null!;

    public long CommentBy { get; set; }

    public DateOnly CommentDate { get; set; }

    public virtual Task Comment1 { get; set; } = null!;

    public virtual ProjectMember CommentNavigation { get; set; } = null!;
}
