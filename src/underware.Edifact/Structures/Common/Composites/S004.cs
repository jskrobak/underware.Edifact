using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.Common.Composites
{
    public class S004
    {

        [ElementInfo(0, "Date of preparation", "M", "", "n6", "")]
        public string E0017 { get; set; }

        [ElementInfo(1, "Time of preparation", "M", "", "n4", "")]
        public string E0019 { get; set; }
    }
}
