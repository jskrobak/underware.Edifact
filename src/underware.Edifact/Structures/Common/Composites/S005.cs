using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.Common.Composites
{
    public class S005
    {
        [ElementInfo(0, "Recipient's reference/password", "M", "", "an..14", "")]
        public string E0022 { get; set; }

        [ElementInfo(1, "Recipient's reference/password qualifier", "C", "", "an2", "")]
        public string E0025 { get; set; }
    }
}
