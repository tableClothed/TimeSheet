using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nowka.Models
{
    public class Timesheet
    {
        public int Id { get; set; }

        public Worker Pracownik { get; set; }

        public Project Projekt { get; set; }

        public DateTime StartHour { get; set; }

        public DateTime EndHour { get; set; }

        public string OpisCzynnosci { get; set; }
    }
}
