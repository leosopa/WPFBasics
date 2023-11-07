using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class Month
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();
}
