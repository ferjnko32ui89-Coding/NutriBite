﻿using System;
using System.Collections.Generic;

namespace NutriBite.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MemorableInfo { get; set; } = null!;
}
