using SeleniumTracker.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SeleniumTracker.Models
{
    public class TestLinkAnnotation
    {
        public int Id { get; set; }
        public string? TestlinkId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public GeneralWorkflow GeneralWorkflow { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SpecificWorkflow SpecificWorkflow { get; set; }
        public bool Ignore { get; set; }
        public string? Comments { get; set; }
        public int AutotestId { get; set; }
    }
}
