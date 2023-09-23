using System;
using System.Collections.Generic;

namespace Core_API_MultiTables.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? City { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
