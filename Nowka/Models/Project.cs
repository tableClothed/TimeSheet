using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nowka.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa projektu")]
        public string Name { get; set; }

        public string Firma { get; set; }

        public DateTime? Termin { get; set; }

        public Worker GroupHead { get; set; }

        public Status Status;
    }
}
