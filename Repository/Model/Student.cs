using System;
using System.Collections.Generic;

namespace Repository.Model;

public partial class Student
{
    public int StudentId { get; set; }

    public int? ProvinceId { get; set; }

    public virtual Province? Province { get; set; }

    public virtual ICollection<Score> Scores { get; set; } = new List<Score>();
}
