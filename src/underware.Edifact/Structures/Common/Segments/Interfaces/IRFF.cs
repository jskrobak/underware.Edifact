using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Structures.Common.Segments.Interfaces
{
    public interface IRFF
    {
        string Qualifier { get; }
        string Value { get; }
    }
}
