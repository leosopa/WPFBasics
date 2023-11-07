using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class PermissionState
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
