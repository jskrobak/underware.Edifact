using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact.Security.Filters
{
    public class HexadecimalFilter : Filter
    {
        public HexadecimalFilter(int code) : base(code)
        {
        }

        public override byte[] Decode(string text)
        {
            return HexEncoding.GetBytes(text);
        }

        public override string Encode(byte[] data)
        {
            return data.ToHexString();
        }
    }
}
