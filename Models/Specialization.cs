namespace Edoc.Models
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Doctor>? Doctors { get; set; } = new List<Doctor>();
    }
}