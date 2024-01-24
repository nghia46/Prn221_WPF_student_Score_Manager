using System;
using System.Collections.Generic;

namespace Repository.Model;

public partial class Score
{
    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public decimal? Score1 { get; set; }

    public int Year { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
