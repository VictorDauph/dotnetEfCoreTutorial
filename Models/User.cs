using System;
using System.Collections.Generic;

namespace dotnetEFcoreDBFirstTutorial.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
