using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Models
{
    public class Abiturient:Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string LastName { get; set; }
        public override string SurName { get; set; }

        public override string PasportNumber { get; set; }

        public override string Address { get; set; }

        public override string PhoneNumber { get; set; }

        public int Reyting { get; set; }

    }
}
