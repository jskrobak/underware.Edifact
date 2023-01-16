using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Security.Filters;

namespace underware.Edifact.Security
{
    public abstract class Filter
    {
        public int Code { get; set; }

        public Filter(int code)
        {
            Code = code;
        }

        public abstract string Encode(byte[] data);
        public abstract byte[] Decode(string text);

        public static Filter GetFilter(FilterType ft)
        {
            return GetFilter((int)ft);
        }

        public static Filter GetFilter(int code)
        {
            if (code == (int)FilterType.HEXADECIMAL)
                return new HexadecimalFilter(code);
            else if (code == (int)FilterType.BASE64)
                return new Base64Filter(code);
            else
                throw new NotSupportedException(string.Format("Filter code={0} is not supported", code));
        }
    }

    public enum FilterType
    {
        HEXADECIMAL = 2,
        BASE64 = 7
    }
}
