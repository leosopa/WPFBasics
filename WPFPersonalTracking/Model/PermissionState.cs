using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class PermissionState : BaseModel
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
