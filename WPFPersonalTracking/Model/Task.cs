﻿using System;
using System.Collections.Generic;

namespace WPFPersonalTracking.Model;

public partial class Task : BaseModel
{
    public int EmployeeId { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int State { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual TaskState StateNavigation { get; set; } = null!;
}
