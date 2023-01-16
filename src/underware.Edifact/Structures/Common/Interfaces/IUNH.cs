using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Structures.Common.Interfaces
{
    public interface IUNH
    {
        string MessageType { get; set; }
        string Version { get; set; }
        string Release { get; set; }
        string ControllingAgency { get; set; }
        string Association { get; set; }
        string MessageReferenceNumber { get; set; }
    }
}
