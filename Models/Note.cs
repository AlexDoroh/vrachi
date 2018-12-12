using System;

namespace Models
{
    public class Note
    {
        public int Id { get; set; }
        public int PacientId { get; set; }
        public int SotrudnikId { get; set; }
        public DateTime NoteTime { get; set; }
    }
}
