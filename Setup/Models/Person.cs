using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Setup.Models
{
    public class Person
    {
        [Required]
        [StringLength(40, ErrorMessage = "Name must be between 0 and 40 chars")]
        public string Name { get; set; }
        
        [Required]
        public int Id { get; set; }
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
