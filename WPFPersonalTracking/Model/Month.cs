using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class Month : BaseModel
{

    public string Name { get; set; } = null!;

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();
}
