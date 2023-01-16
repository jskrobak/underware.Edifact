using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Attributes
{
    public class ElementInfo : Attribute
    {
        public ElementInfo(int index, string desc, string mc, string repeat, string repr, string notes)
        {
            OrderIndex = index;
            Description = desc;
            MC = mc;
            Repeat = repeat;
            Repr = repr;
            Notes = notes;
            Notes = notes;
        }

        public ElementInfo(int index, string desc)
        {
            OrderIndex = index;
            Description = desc;
        }

        public int OrderIndex { get; set; }
        public string Description { get; set; }
        public string MC { get; set; }
        public string Repeat { get; set; }
        public string Repr { get; set; }
        public string Notes { get; set; }

        public string PropertyName { get; set; }
    }
}
