﻿using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class User:Auditable
{
    public string FriendlyName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Bio { get; set; }

}