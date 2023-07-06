using System;
using System.Collections.Generic;

namespace WebEf;

public partial class Student
{
    public int StuId { get; set; }

    public string StudName { get; set; } = null!;

    public string City { get; set; } = null!;

    public int Pin { get; set; }
}
