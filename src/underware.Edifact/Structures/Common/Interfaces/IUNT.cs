using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Structures.Common.Interfaces
{
    public interface IUNT
    {
        int SegmentsCount { get; set; }
        string MessageReferenceNumber { get; set; }
        string OriginalContent { get; set; }
    }
}
