using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class Position : BaseModel
{
    public string Name { get; set; } = null!;

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
