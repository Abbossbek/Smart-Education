using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Database
{
    class Payment
    {
        public int Id { get; set; }
        public Month Oy { get; set; }
        public bool IsPaid { get; set; }
        public int AbiturientId { get; set; }
        public int CourseId { get; set; }
    }
}
