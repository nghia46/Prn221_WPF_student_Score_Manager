using System;
using System.Collections.Generic;

namespace Repository.Model;

public partial class Province
{
    public int ProvinceId { get; set; }

    public string? ProvinceName { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
