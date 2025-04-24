using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Structures.Common.Composites;

namespace underware.Edifact
{
    public class Syntax
    {

        public Syntax() { }
        public Syntax(S001 s001)
        {
            Identifier = s001.E0001;
            Version = int.Parse(s001.E0002);
        }


        public string Identifier { get; set; }
        public int Version { get; set; }

        public S001 ToS001()
        {
            return new S001()
            {
                E0001 = Identifier,
                E0002 = Version.ToString()
            };
        }

        public static Syntax UNOA3 = new Syntax() { Identifier = "UNOA", Version = 3 };
        public static Syntax UNOB3 = new Syntax() { Identifier = "UNOB", Version = 3 };
        public static Syntax UNOC3 = new Syntax() { Identifier = "UNOC", Version = 3 };
        public static Syntax UNOD3 = new Syntax() { Identifier = "UNOD", Version = 3 };
        public static Syntax UNOD4 = new Syntax() { Identifier = "UNOD", Version = 4 };




    }
}
