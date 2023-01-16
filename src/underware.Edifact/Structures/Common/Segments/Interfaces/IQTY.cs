using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Structures.Common.Segments.Interfaces
{
    public interface IQTY
    {
        string Qualifier { get; }
        string Unit { get; }
        decimal Value { get; }
    }
}
