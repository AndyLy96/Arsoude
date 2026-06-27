using Arsoude_Backend.Models.Enums;
using System.Text.Json.Serialization;

namespace Arsoude_Backend.Models
{
    public class NotificationSettings
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual TrailType Type { get; set; }

        public double? Distance { get; set; }

        public bool IsTurnedOn { get; set; }

       
    }
}
