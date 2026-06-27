using System.Text.Json.Serialization;

namespace Arsoude_Backend.Models
{
    public class Event
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string? UserName { get; set; }
        //public int? Time { get; set; }

        //public int TrailId { get; set; }

        public bool? IsCompleted { get; set; }
        public bool? IsNew { get; set; }

        //public string? TrailName { get; set; }

        //public bool? IsPublic { get; set; }

        public virtual Trail? Trail { get; set; }
        
    }
}
