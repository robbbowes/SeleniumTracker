using System.ComponentModel.DataAnnotations.Schema;

namespace SeleniumTracker.Models
{
    public class Failure
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Details { get; set; }
        public Resolution? Resolution { get; set; }
        public int AutotestId { get; set; }
        public Autotest Autotest { get; set; }
    }
}
