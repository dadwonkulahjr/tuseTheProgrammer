﻿using System;

namespace tuseTheProgrammer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
        public Gender Gender { get; set; }
    }
}
