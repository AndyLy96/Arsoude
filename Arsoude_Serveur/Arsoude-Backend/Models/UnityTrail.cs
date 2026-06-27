using Arsoude_Backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Arsoude_Backend.Models
{
    public class UnityTrailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TrailType Type { get; set; }
        public string? Location { get; set; }
        public List<string> ImageUrlList { get; set; }
    }
}
