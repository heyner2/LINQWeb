﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LINQProject.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
    }
}
