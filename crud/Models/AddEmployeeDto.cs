﻿using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class AddEmployeeDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Salary { get; set; }
    }
}
