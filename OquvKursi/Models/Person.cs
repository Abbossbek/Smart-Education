using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Models
{
   public abstract class Person
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string LastName { get; set; }
        public abstract string SurName { get; set; }

        public abstract string PasportNumber { get; set; }

        public abstract string Address { get; set; }

        public abstract string PhoneNumber { get; set; }

    }
}
