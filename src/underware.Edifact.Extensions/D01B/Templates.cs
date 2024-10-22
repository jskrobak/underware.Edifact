using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.D01B.Composites;
using underware.Edifact.D01B.Segments;
using underware.Edifact.Structures.S3.Segments;

namespace underware.Edifact.D01B
{
    public static class Templates
    {
        public static BGM BGM(string docType, string billNo, string function = "9")
        {
            return new BGM()
            {
                C002 = new C002() { E1001 = docType },
                C106 = new C106() { E1004 = billNo },
                E1225 = function
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

        public static CNT CNT(string qualf, decimal itemsCount)
        {
            return new CNT()
            {
                C270 = new C270()
                {
                    E6069 = qualf,
                    E6066 = itemsCount.ToString("0.00", CultureInfo.InvariantCulture)
                }
            };
        }
        
        public static CNT CNT(string qualf, string itemsCount)
        {
            return new CNT()
            {
                C270 = new C270()
                {
                    E6069 = qualf,
                    E6066 = itemsCount
                }
            };
        }

        public static Segment CPS(string hierarchicalLevelId, string hierarchicalParentId, string packagingLevelCode)
        {
            return new CPS()
            {
                E7164 = hierarchicalLevelId,
                E7166 = hierarchicalParentId,
                E7075 = packagingLevelCode
            };
        }
        
        public static Segment CPS(string hierarchicalLevelId)
        {
            return new CPS()
            {
                E7164 = hierarchicalLevelId
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

        public static CUX CUX(string currency, string homeCurrency, decimal rate)
        {
            return new CUX()
            {
                C504 = new C504()
                {
                    E6347 = "2",
                    E6345 = currency,
                    E6343 = "4"
                },
                C504_0 = new C504()
                {
                    E6347 = "3",
                    E6345 = homeCurrency,
                    E6343 = "10E"
                },
                E5402 = rate.ToString("0.00", CultureInfo.InvariantCulture)
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

        public static FII FII(string accountNo, string bankCode, string vs, string ks, string swift, string iban)
        {
            return new FII()
            {
                E3035 = "RB",
                C078 = new C078()
                {
                    E3194 = accountNo,
                    E3192_0 = vs,
                    E3192 = ks
                },
                C088 = new C088()
                {
                    E3434 = swift,
                    E3436 = iban,
                    E3433 = bankCode
                }
            };
        }

        public static FII FII(string qualf, string accountNo, string vs, string ks, string bankCode)
        {
            return new FII()
            {
                E3035 = qualf,
                C078 = new C078()
                {
                    E3194 = accountNo,
                    E3192 = ks,
                    E3192_0 = vs
                },
                C088 = new C088()
                {
                    E3433 = bankCode
                }
            };
        }

        public static FII FII_CZ(string accountNo, string bankCode, string vs, string ks)
        {
            return new FII()
            {
                E3035 = "RB",
                C078 = new C078()
                {
                    E3194 = accountNo,
                    E3192 = ks,
                    E3192_0 = vs
                },
                C088 = new C088()
                {
                    E3433 = bankCode
                }
            };
        }

        public static FTX FTX(string qualf, string text, string language ="")
        {
            string[] parts = text.SplitToChunks(512, 5);

            return FTX(qualf, parts[0], parts[1], parts[2], parts[3], parts[4], language);
        }

        
        public static FTX FTX(string qualf, string text1, string text2, string text3="", string text4="", string text5="", string language="")
        {
            return new FTX()
            {
                E4451 = qualf,
                C108 = new C108()
                {
                    E4440 = text1,
                    E4440_0 = text2,
                    E4440_1 = text3,
                    E4440_2 = text4,
                    E4440_3 = text5
                },
                E3453 = language
            };
        }

        public static Segment GEI(string qualf, string agency)
        {
            return new GEI()
            {
                E9649 = qualf,
                C012 = new C012() { E3055 = agency }
            };
        }

        public static DateTime GetDate(this DTM dtm)
        {
            DateTime date = DateTime.MinValue;
            DateTime.TryParseExact(dtm.C507.E2380, GetFormat(dtm).Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

            return date;
        }

        public static DateTimeFormat GetFormat(this DTM dtm)
        {
            return DateTimeFormat.Parse(dtm.C507.E2379);
        }

        public static string GetQualf(this DTM dtm)
        {
            return dtm.C507.E2005;
        }

        public static GIN GIN(string qualifier, string identifier)
        {
            string[] parts = identifier.SplitToChunks(35, 10);
            return new GIN()
            {
                E7405 = qualifier,
                C208 = new C208()
                {
                    E7402 = parts[0],
                    E7402_0 = parts[1],
                },
                C208_0 = new C208()
                {
                    E7402 = parts[2],
                    E7402_0 = parts[3],
                },
                C208_1 = new C208()
                {
                    E7402 = parts[4],
                    E7402_0 = parts[5],
                },
                C208_2 = new C208()
                {
                    E7402 = parts[6],
                    E7402_0 = parts[7],
                },
                C208_3 = new C208()
                {
                    E7402 = parts[8],
                    E7402_0 = parts[9],
                }
            };
        }

        public static IMD IMD(string formatCode, decimal? value1, decimal? value2)
        {
            return new IMD()
            {
                E7077 = formatCode,
                C273 = new C273()
                {
                    E7008 = value1.Value.ToString("0.00",CultureInfo.InvariantCulture),
                    E7008_0 = value2.Value.ToString("0", CultureInfo.InvariantCulture)
                }
            };
        }

        public static IMD IMD(string formatCode, string descCode, string desc, string itemCharacteristicCode = "", string agency = "")
        {
            string[] parts = desc.SplitToChunks(256, 2);

            return new IMD()
            {
                E7077 = formatCode,
                C272 = new C272()
                {
                    E7081 = itemCharacteristicCode,
                    E3055 = agency
                },
                C273 = new C273()
                {
                    E7009 = descCode,
                    E7008 = parts[0],
                    E7008_0 = parts[1]
                }
            };
        }

        public static INV INV(string balanceMethodCode)
        {
            return new INV()
            {
                E4503 = balanceMethodCode
            };
        }
                
        

        public static LIN LIN(string lineNo, string code, string codeType = "", string agency = "", string action = "")
        {
            return new LIN()
            {
                E1229 = action,
                E1082 = lineNo,
                C212 = new C212()
                {
                    E7140 = code,
                    E7143 = codeType,
                    E3055 = agency,
                }
            };
        }

        public static MOA MOA(string qualf, decimal amount, string decimalFormat = "0.00")
        {
            return new MOA()
            {
                C516 = new C516()
                {
                    E5025 = qualf,
                    E5004 = amount.ToString(decimalFormat, CultureInfo.InvariantCulture)
                }
            };
        }

        public static MOA MOA(string qualf, decimal amount, string currency, string code, string decimalFormat = "0.00")
        {
            return new MOA()
            {
                C516 = new C516()
                {
                    E5025 = qualf,
                    E5004 = amount.ToString(decimalFormat, CultureInfo.InvariantCulture),
                    E6345 = currency,
                    E6343 = code
                }
            };
        }

        public static NAD NAD(string qualf, string gln)
        {
            return new NAD()
            {
                E3035 = qualf,
                C082 = new C082()
                {
                    E3039 = gln,
                    E3055 = "9"
                }
            };
        }

        public static NAD NAD(string qualf, string gln, string agency)
        {
            return new NAD()
            {
                E3035 = qualf,
                C082 = new C082()
                {
                    E3039 = gln,
                    E3055 = agency
                }
            };
        }

        public static NAD NAD(string qualf, string gln, string name, string street, string city, string zip, string countryCode)
        {
            return NAD(qualf, gln, "9", name, street, city, zip, countryCode);
        }

        public static NAD NAD(string qualf, string code, string agency, string name, string street, string city, string zip, string countryCode)
        {
            string[] nameParts = name.SplitToChunks(35, 5);
            string[] streetParts = street.SplitToChunks(35, 5);
            return new NAD()
            {
                E3035 = qualf,
                C082 = new C082()
                {
                    E3039 = code,
                    E3055 = agency
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

        public static PAC PAC(string packageQty, string packageTypeDescCode)
        {
            return new PAC()
            {
                E7224 = packageQty,
                C202 = new C202()
                {
                    E7065 = packageTypeDescCode
                }
            };
        }
        
        public static PAC PAC(string packageQty, string packageTypeDescCode, string agencyCode)
        {
            return new PAC()
            {
                E7224 = packageQty,
                C202 = new C202()
                {
                    E7065 = packageTypeDescCode,
                    E3055 = agencyCode
                }
            };
        }


        public static PAI PAI(int paymentType)
        {
            return new PAI()
            {
                C534 = new C534() { E4461 = paymentType.ToString() }
            };
        }

        public static PAI PAI(string paymentType, string conditionsCode)
        {
            return new PAI()
            {
                C534 = new C534()
                {
                    E4439 = conditionsCode,
                    E4461 = paymentType
                }
            };
        }
        public static PAT PAT(string qualf)
        {
            return new PAT()
            {
                E4279 = qualf
            };
        }

        public static PCI PCI(string markingInstructionCode)
        {
            return new PCI()
            {
                E4233 = markingInstructionCode
            };
        }

        public static PIA PIA(string qualf, string code, string codeType)
        {
            return PIA(qualf, code, codeType, "");
        }

        public static PIA PIA(string qualf, string code, string codeType, string agency)
        {
            return new PIA()
            {
                E4347 = qualf,
                C212 = new C212()
                {
                    E7140 = code,
                    E7143 = codeType,
                    E3055 = agency
                }
            };
        }

        public static PRI PRI(string qualf, decimal price, string decimalFormat = "0.000")
        {
            return new PRI()
            {
                C509 = new C509()
                {
                    E5125 = qualf,
                    E5118 = price.ToString(decimalFormat, CultureInfo.InvariantCulture)
                }
            };
        }

        public static PRI PRI(string qualf, decimal price, string priceCode, decimal basis, string unit, string decimalFormat = "0.000")
        {
            return new PRI()
            {
                C509 = new C509()
                {
                    E5125 = qualf,
                    E5118 = price.ToString(decimalFormat, CultureInfo.InvariantCulture),
                    E5387 = priceCode,
                    E5284 = basis.ToString("0"),
                    E6411 = unit
                }

            };
        }

        public static QTY QTY(string qualf, string unitCode, decimal qty, string decimalFormat = "0")
        {
            return new QTY()
            {
                C186 = new C186()
                {
                    E6063 = qualf,
                    E6060 = qty.ToString(decimalFormat, CultureInfo.InvariantCulture),
                    E6411 = unitCode
                }
            };
        }

        public static QTY QTY(string qualf, decimal qty, string decimalFormat = "0")
        {
            return new QTY()
            {
                C186 = new C186()
                {
                    E6063 = qualf,
                    E6060 = qty.ToString(decimalFormat, CultureInfo.InvariantCulture)
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
        public static string[] SplitToChunks(this string text, int chunkSize, int chunks)
        {
            var parts = new string[chunks];

            if (string.IsNullOrWhiteSpace(text)) return parts;
            
            int textPos = 0;
            int part = 0;
            while (textPos < text.Length && part < parts.Length)
            {
                int len = (textPos + chunkSize >= text.Length) ? text.Length - textPos : chunkSize;

                parts[part] = text.Substring(textPos, len);
                textPos += chunkSize;
                part += 1;
            }

            return parts;
        }

        public static TAX TAX(string qualf, string type)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type }
            };
        }
       
        public static TAX TAX(string qualf, string type, string name, decimal basis)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type },
                E5286 = basis.ToString("0.00", CultureInfo.InvariantCulture),
                C243 = new C243() { E5279 = name }
            };
        }
        
        public static TAX TAX(string qualf, string type, string name, decimal basis, decimal rate)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type },
                E5286 = basis.ToString("0.00", CultureInfo.InvariantCulture),
                C243 = new C243() { E5279 = name, E5278 = rate.ToString("0.00", CultureInfo.InvariantCulture) }
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

        public static TAX TAX(string qualf, string type, decimal rate, string category, string rateCode)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type },
                C243 = new C243()
                {
                    E5279 = rateCode,
                    E5278 = rate.ToString("0.00", CultureInfo.InvariantCulture)
                },
                E5305 = category
            };
        }

        public static TAX TAX(string qualf, string type, decimal rate)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type },
                C243 = new C243() { E5278 = rate.ToString("0.00", CultureInfo.InvariantCulture) }
            };
        }

        public static UNS UNS()
        {
            return new UNS()
            {
                E0081 = "S"
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

        public static Segment TOD(string transportFunctionCode, string desc="")
        {
            return new TOD()
            {
                E4055 = transportFunctionCode,
                C100 = new C100()
                {
                    E4052 = desc
                }
            };

        }

        public static Segment TDT(string qualf)
        {
            return new TDT()
            {
                E8051 = qualf
            };
        }
    }
}
