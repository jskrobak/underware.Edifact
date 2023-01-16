using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Structures.Common.Interfaces
{
    public interface IUSH
    {
        DateTime Date { get; }
        int Filter { get; }
    }
}
