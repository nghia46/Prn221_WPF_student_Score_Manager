using System;
using System.Collections.Generic;

namespace Repository.Model;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public virtual ICollection<Score> Scores { get; set; } = new List<Score>();
}
