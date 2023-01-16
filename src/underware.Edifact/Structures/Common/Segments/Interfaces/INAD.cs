using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Structures.Common.Segments.Interfaces
{
    public interface INAD
    {
        string Qualifier { get; }
        string Identifier { get; }
        string PartyName { get; }
    }
}
