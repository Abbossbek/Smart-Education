using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Database
{
    public class Abituriyent:Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string PasportNumber { get; set; }
        public override int Address { get; set; }
        public override int PNumber { get; set; }
        public string Reyting { get; set; }
    }
}
