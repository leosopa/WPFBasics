using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Repository;

public partial class Taskstate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
