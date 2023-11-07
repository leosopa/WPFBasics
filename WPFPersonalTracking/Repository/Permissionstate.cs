using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Repository;

public partial class Permissionstate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
