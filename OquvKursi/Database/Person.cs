using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Database
{
    public abstract class Person
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string PasportNumber { get; set; }
        public abstract int Address { get; set; }
        public abstract int PNumber { get; set; }


    }
}
