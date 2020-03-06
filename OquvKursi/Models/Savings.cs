using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Models
{
    public class Savings
    {
        public int Id { get; set; }

        public double Summa { get; set; }
        public DateTime PayTime { get; set; }
        public int AbiturientId { get; set; }
    }
}
