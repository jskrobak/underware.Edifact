using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class TAX : Segment
    {
        public TAX() : base("TAX", "Duty/tax/fee details") { }

        [ElementInfo(0, "Duty or tax or fee function code qualifier", "M", "1", "an..3", "")]
        public string E5283 { get; set; }
        [ElementInfo(1, "DUTY/TAX/FEE TYPE", "C", "1", "", "")]
        public C241 C241 { get; set; }
        [ElementInfo(2, "DUTY/TAX/FEE ACCOUNT DETAIL", "C", "1", "", "")]
        public C533 C533 { get; set; }
        [ElementInfo(3, "Duty or tax or fee assessment basis value", "C", "1", "an..15", "")]
        public string E5286 { get; set; }
        [ElementInfo(4, "DUTY/TAX/FEE DETAIL", "C", "1", "", "")]
        public C243 C243 { get; set; }
        [ElementInfo(5, "Duty or tax or fee category code", "C", "1", "an..3", "")]
        public string E5305 { get; set; }
        [ElementInfo(6, "Party tax identifier", "C", "1", "an..20", "")]
        public string E3446 { get; set; }
        [ElementInfo(7, "Calculation sequence code", "C", "1", "an..3", "")]
        public string E1227 { get; set; }


    }
}