using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nowka.Models
{
    public class Worker
    {

        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Uprawnienia { get; set; }

        [Display(Name = "Projekty")]
        public List<Project> ParticipatingProjects { get; set; }
    }
}
