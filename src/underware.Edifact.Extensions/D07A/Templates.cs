using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.D07A.Composites;
using underware.Edifact.D07A.Segments;

namespace underware.Edifact.D07A
{
    public static class Templates
    {
        public static ALI ALI(string countryCode)
        {
            return new ALI()
            {
                E3239 = countryCode
            };
        }

        public static PAC PAC(string qty, string typeDescCode)
        {
            return new PAC()
            {
                E7224 = qty,
                C202 = new C202() { E7065 = typeDescCode }
            };
        }

        public static BGM BGM(string docType, string billNo, string function = "9")
        {
            return new BGM()
            {
                C002 = new C002() { E1001 = docType },
                C106 = new C106() { E1004 = billNo },
                E1225 = function
            };
        }

        public static DTM DTM(string qualf, DateTime date, DateTimeFormat format)
        {
            return new DTM()
            {
                C507 = new C507()
                {
                    E2005 = qualf,
                    E2380 = date.ToString(format.Format),
                    E2379 = format.Code
                }
            };
        }

        public static LOC LOC(string qualf, string code)
        {
            return new LOC()
            {
                E3227 = qualf,
                C517 = new C517() { E3224 = code }
            };
        }

        public static PAI PAI(int paymentType)
        {
            return new PAI()
            {
                C534 = new C534() { E4461 = paymentType.ToString() }
            };
        }

        public static FTX FTX(string qualf, string text)
        {
            string[] parts = text.SplitToChunks(512, 5);

            return new FTX()
            {
                E4451 = qualf,
                C108 = new C108()
                {
                    E4440 = parts[0],
                    E4440_0 = parts[1],
                    E4440_1 = parts[2],
                    E4440_2 = parts[3],
                    E4440_3 = parts[4]
                }
            };
        }

        public static PYT PYT(string typeCode, string timeRefCode, string timeRelCode, string periodType, int periodCountQty)
        {
            return new PYT()
            {
                E4279 = typeCode,
                E2475 = timeRefCode,
                E2009 = timeRelCode,
                E2151 = periodType,
                E2152 = periodCountQty.ToString()
            };
        }

        public static PIA PIA(string suppliersCode)
        {
            return new PIA()
            {
                E4347 = "1",
                C212 = new C212()
                {
                    E7140 = suppliersCode,
                    E7143 = "SA"
                }
            };
        }
        public static RFF RFF(string qualf, string text)
        {
            return new RFF()
            {
                C506 = new C506()
                {
                    E1153 = qualf,
                    E1154 = text
                }
            };
        }

        public static RFF RFF(string qualf, string text, string line)
        {
            return new RFF()
            {
                C506 = new C506()
                {
                    E1153 = qualf,
                    E1154 = text,
                    E1156 = line
                }
            };
        }


        public static NAD NAD(string qualf, string gln, string name, string street, string city, string zip, string countryCode)
        {
            string[] nameParts = name.SplitToChunks(35, 5);
            string[] streetParts = street.SplitToChunks(35, 5);
            return new NAD()
            {
                E3035 = qualf,
                C082 = new C082()
                {
                    E3039 = gln,
                    E3055 = "9"
                },
                C080 = new C080()
                {
                    E3036 = nameParts[0],
                    E3036_0 = nameParts[1],
                    E3036_1 = nameParts[2],
                    E3036_2 = nameParts[3],
                    E3036_3 = nameParts[4]
                },
                C059 = new C059()
                {
                    E3042 = streetParts[0],
                    E3042_0 = streetParts[1],
                    E3042_1 = streetParts[2],
                    E3042_2 = streetParts[3]
                },
                E3164 = city,
                E3251 = zip,
                E3207 = countryCode
            };
        }

        public static FII FII(string accountNo, string invoiceNo, string swift, string iban)
        {
            return new FII()
            {
                E3035 = "RB",
                C078 = new C078()
                {
                    E3194 = accountNo,
                    E3192_0 = invoiceNo
                },
                C088 = new C088()
                {
                    E3434 = swift,
                    E3432 = iban
                }
            };
        }
        public static CUX CUX(string currency)
        {
            return new CUX()
            {
                C504 = new C504()
                {
                    E6347 = "2",
                    E6345 = currency,
                    E6343 = "4"
                }
            };
        }

      
        public static LIN LIN(string lineNo, string code, string codeType)
        {
            return new LIN()
            {
                E1082 = lineNo,
                C212 = new C212()
                {
                    E7140 = code,
                    E7143 = codeType
                }
            };
        }

        public static IMD IMD(string formatCode, string descCode, string desc)
        {
            string[] parts = desc.SplitToChunks(256, 2);

            return new IMD()
            {
                E7077 = formatCode,
                C273 = new C273()
                {
                    E7009 = descCode,
                    E7008 = parts[0],
                    E7008_0 = parts[1]
                }
            };
        }

        public static MEA MEA(string qualifier, string measureAttCode, string unitCode, string value)
        {
            return new MEA()
            {
                E6311 = qualifier,
                C502 = new C502()
                {
                    E6313 = measureAttCode
                },
                C174 = new C174()
                {
                    E6411 = unitCode,
                    E6314 = value
                }
            };
        }

        public static QTY QTY(string qualf, decimal qty, string unitCode)
        {
            return new QTY()
            {
                C186 = new C186()
                {
                    E6063 = qualf,
                    E6060 = qty.ToString("0"),
                    E6411 = unitCode
                }
            };
        }

        public static Segment COM(string comunicationType, string address)
        {
            return new COM()
            {
                C076 = new C076()
                {
                    E3148 = address,
                    E3155 = comunicationType
                }
            };
        }

        public static Segment CTA(string type, string person)
        {
            return new CTA()
            {
                E3139 = type,
                C056 = new C056()
                {
                    E3412 = person
                }
            };
        }

        public static MOA MOA(string qualf, decimal amount)
        {
            return new MOA()
            {
                C516 = new C516()
                {
                    E5025 = qualf,
                    E5004 = amount.ToString("0.00", CultureInfo.InvariantCulture)
                }
            };
        }

        public static PRI PRI(string qualf, decimal price)
        {
            return new PRI()
            {
                C509 = new C509()
                {
                    E5125 = qualf,
                    E5118 = price.ToString("0.00", CultureInfo.InvariantCulture)
                }
            };
        }

        public static TOD TOD(string descCode, string agencyCode)
        {
            return new TOD()
            {
                C100 = new C100()
                {
                    E4053 = descCode,
                    E3055 = agencyCode
                } 
            };
        }

        public static TAX TAX(string qualf, string type, decimal rate, string category)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type },
                C243 = new C243() { E5278 = rate.ToString("0.00", CultureInfo.InvariantCulture) },
                E5305 = category
            };
        }

        public static UNS UNS()
        {
            return new UNS()
            {
                E0081 = "S"
            };
        }
        public static CNT CNT(int itemsCount)
        {
            return new CNT()
            {
                C270 = new C270()
                {
                    E6069 = "2",
                    E6066 = itemsCount.ToString()
                }
            };
        }

        public static string[] SplitToChunks(this string text, int chunkSize, int chunks)
        {
            string[] parts = new string[chunks];
            int textPos = 0;
            int part = 0;
            while(textPos < text.Length && part < parts.Length)
            {
                int len = (textPos + chunkSize >= text.Length) ? text.Length - textPos : chunkSize;

                parts[part] = text.Substring(textPos, len);
                textPos += chunkSize;
                part += 1;
            }

            return parts;
        }

        public static DateTime GetDate (this DTM dtm)
        {
            DateTime date = DateTime.MinValue;
            DateTime.TryParseExact(dtm.C507.E2380, GetFormat(dtm).Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

            return date;
        }

        public static DateTimeFormat GetFormat(this DTM dtm)
        {
            return DateTimeFormat.GetFromEdi(dtm.C507.E2379);
        }

        public static string GetQualf(this DTM dtm)
        {
            return dtm.C507.E2005;
        }
    }
}
