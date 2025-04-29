using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Structures.Common.Composites;

namespace underware.Edifact
{
    public class Party
    {
        public Party(string id, string qualf, string intId)
        {
            Identifier = id;
            Qualifier = qualf;
            InternalCode = intId;
        }

        public string Identifier { get; set; }
        public string Qualifier { get; set; }
        public string InternalCode { get; set; }

        public S002 Sender =>
            new()
            {
                E0004 = Identifier,
                E0007 = Qualifier,
                E0008 = InternalCode
            };

        public S003 Receiver =>
            new()
            {
                E0010 = Identifier,
                E0007 = Qualifier,
                E0014 = InternalCode
            };

        public static Party EAN(string id)
        {
            return new Party(id, "14", "");
        }

        public static Party ZZZ(string id)
        {
            return new Party(id, "ZZZ", "");
        }
        
        public static Party ZZ(string id)
        {
            return new Party(id, "ZZ", "");
        }
        
        public static Party NoAgency(string id)
        {
            return new Party(id, "", "");
        }
        
    }
}
