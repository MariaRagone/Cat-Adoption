using System;
using System.Collections.Generic;

namespace Cat_Adoption.Models;

public partial class Cat
{
    public int Id { get; set; }

    public string? Img { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Age { get; set; }

    public string? AgeCategory { get; set; }

    public string? Breed { get; set; }

    public bool? Fixed { get; set; }
}
