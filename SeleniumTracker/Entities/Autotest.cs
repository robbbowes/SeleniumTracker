using SeleniumTracker.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SeleniumTracker.Models
{
    public class Autotest
    {
        public int Id { get; set; }
        public string Package { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Priority Priority { get; set; }
        public bool Failing { get; set; }
        public TestLinkAnnotation TestLinkAnnotation { get; set; }
        public int CodelineId { get; set; }
        public Codeline Codeline { get; set; }
        public List<Failure> Failures { get; set; }
    }
}
