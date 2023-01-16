using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Security.Filters
{
    public class Base64Filter : Filter
    {
        public Base64Filter(int code) : base(code)
        {
        }

        public override byte[] Decode(string text)
        {
            return Convert.FromBase64String(text);
        }

        public override string Encode(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
    }
}
