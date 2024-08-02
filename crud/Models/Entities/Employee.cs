using System;
using System.ComponentModel.DataAnnotations;

namespace crud.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required]
        public  string Name { get; set; }

        [Required]
        public  string Email { get; set; }

        public string Phone { get; set; }

        public string Salary { get; set; }
    }
}
