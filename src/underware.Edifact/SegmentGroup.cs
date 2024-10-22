using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

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

        
        public List<SegmentGroup> FindGroups(string name, bool recursive = false)
        {
            var list = new List<SegmentGroup>();

            FindGroups(this, name, list, recursive);

            return list;
        }

        private static void FindGroups(SegmentGroup parent, string name, List<SegmentGroup> result,
            bool recursive = false)
        {
            result.AddRange(parent.Groups.Where(g => g.Name == name));

            if(!recursive)
                return;
            
            foreach(var group in parent.Groups)
            {
                FindGroups(group, name, result);
            }
            
        }
        
    }
}
