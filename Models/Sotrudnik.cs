using System;

namespace Models
{
    public class Sotrudnik
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string CabNumber { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
    }
}
