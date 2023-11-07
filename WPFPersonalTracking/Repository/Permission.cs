using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Repository;

public partial class Permission
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int State { get; set; }

    public string? Explanation { get; set; }

    public int Day { get; set; }

    public int EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Permissionstate StateNavigation { get; set; } = null!;
}
