using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class TaskState : BaseModel
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
