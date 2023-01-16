using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace underware.Edifact
{
    public class SegmentGroup : SegmentGroupItem
    {
        public SegmentGroup(string name)
        {
            Name = name;
            Children = new List<SegmentGroupItem>();
        }

        public string Name { get; set; }
        public List<SegmentGroupItem> Children { get; set; }

        public IEnumerable<SegmentGroup> Groups { get => Children.OfType<SegmentGroup>(); }
        public IEnumerable<Segment> Segments { get => Children.OfType<Segment>(); }

        /*
        public SegmentGroup FindGroup(string name)
        {
            return FindGroup(this, name);
        }

        private SegmentGroup FindGroup(SegmentGroup parent, string name)
        {
            SegmentGroup sg = parent.Children.OfType<SegmentGroup>().Where(s => s.Name == name).FirstOrDefault();

            if (sg != null)
                return sg;

            foreach(SegmentGroup childSg in Children.OfType<SegmentGroup>())
            {
                sg = FindGroup(childSg, name);

                if (sg != null)
                    return sg;
            }

            return null;
        }
        */
    }
}
