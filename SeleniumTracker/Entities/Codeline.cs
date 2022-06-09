namespace SeleniumTracker.Models
{
    public class Codeline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Autotest> Autotests { get; set; }
    }
}
