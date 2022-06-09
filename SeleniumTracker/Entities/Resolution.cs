using System.ComponentModel.DataAnnotations.Schema;

namespace SeleniumTracker.Models
{
    public class Resolution
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public int FailureId { get; set; }
    }
}
