using System.ComponentModel.DataAnnotations;

namespace SD340Labs.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        
        public enum Section
        {
            First,
            Second,
            Third
        };
    }
}
