using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.D96A.Composites;
using underware.Edifact.D96A.Segments;
using underware.Edifact.Structures.S3.Segments;

namespace underware.Edifact.D96A
{
    public static class Templates
    {

        public static Segment IMD(string qualf, string text)
        {

            string[] parts = text.SplitToChunks(35, 2);

            return new IMD()
            {
                E7077 = qualf,
                C273 = new C273()
                {
                    E7008 = parts[0],
                    E7008_0 = parts[1]
                }
            };
        }

        public static Segment ALC(string qualf, string discountCode)
        {
            return new ALC()
            {
                E5463 = qualf,
                C552 = new C552()
                {
                    E1230 = "A"
                },
                E4471 = discountCode
            };
        }

        public static BGM BGM(string docType, string billNo, string function = "9")
        {
            return new BGM()
            {
                C002 = new C002() { E1001 = docType },
                E1004 = billNo,
                E1225 = function
            };
        }

        public static CNT CNT(int itemsCount)
        {
            return CNT("2", itemsCount);
        }

        public static CNT CNT(string qualifier, int cnt)
        {
            return new CNT()
            {
                C270 = new C270()
                {
                    E6069 = qualifier,
                    E6066 = cnt.ToString()
                }
            };
        }

        public static CNT CNT(string qualifier, decimal cnt)
        {
            return new CNT()
            {
                C270 = new C270()
                {
                    E6069 = qualifier,
                    E6066 = cnt.ToString("0.00", CultureInfo.InvariantCulture)
                }
            };
        }

        public static Segment CPS()
        {
            return new CPS()
            {
                E7164 = "1"
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

        public static CUX CUX(string invCurrCode, string homeCurrCode, string rateBase, string rate)
        {
            return new CUX()
            {
                C504 = new C504()
                {
                    E6347 = "2",
                    E6345 = invCurrCode,
                    E6343 = "4",
                    E6348 = rateBase
                },
                C504_0 = new C504()
                {
                    E6347 = "3",
                    E6345 = homeCurrCode,
                    E6343 = "10E"
                },
                E5402 = rate
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

        public static FII FII(string qualf, string accountNo, string varSymbol, string constSymbol, string bankCode,
            string bankName, string swift, string iban)
        {
            return new FII()
            {
                E3035 = qualf,
                C078 = new C078()
                {
                    E3194 = accountNo,
                    E3192 = constSymbol,
                    E3192_0 = varSymbol
                },
                C088 = new C088()
                {
                    E3433 = bankCode,
                    E3434 = swift,
                    E3432 = bankName,
                    E3436 = iban
                }
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

        public static FII FII_CZ(string accountNo, string constSymbol, string varSymbol, string bankCode)
        {
            return new FII()
            {
                E3035 = "RB",
                C078 = new C078()
                {
                    E3194 = accountNo,
                    E3192 = constSymbol,
                    E3192_0 = varSymbol
                },
                C088 = new C088()
                {
                    E3433 = bankCode
                }
            };
        }

        public static FTX FTX(string qualf, string text2)
        {
            var parts = text2.SplitToChunks(70, 5);

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

        public static FTX FTX(string qualf, string functionCode, string text1, string text2)
        {
            string[] parts = text2.SplitToChunks(512, 5);

            return new FTX()
            {
                E4451 = qualf,
                E4453 = functionCode,
                C107 = new C107()
                {
                    E4441 = text1
                },
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

        public static FTX FTX(string qualf, string functionCode, string text1, string text2 = "", string agency = "",
            string langCode = "")
        {
            string[] parts = text2.SplitToChunks(512, 5);

            return new FTX()
            {
                E4451 = qualf,
                E4453 = functionCode,
                C107 = new C107()
                {
                    E4441 = text1,
                    E3055 = agency
                },
                C108 = new C108()
                {
                    E4440 = parts[0],
                    E4440_0 = parts[1],
                    E4440_1 = parts[2],
                    E4440_2 = parts[3],
                    E4440_3 = parts[4]
                },
                E3453 = langCode
            };
        }

        public static FTX FTX(string qualf, string functionCode, string text)
        {
            string[] parts = text.SplitToChunks(512, 5);

            return new FTX()
            {
                E4451 = qualf,
                E4453 = functionCode,
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

        public static DateTime GetDate(this DTM dtm)
        {
            DateTime date = DateTime.MinValue;
            DateTime.TryParseExact(dtm.C507.E2380, GetFormat(dtm).Format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out date);

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

        public static IMD IMD(string formatCode, string descCode, string desc)
        {
            string[] parts = desc.SplitToChunks(35, 2);

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

        public static LIN LIN(string lineNo, string code, string codeType, string respAgency)
        {
            return new LIN()
            {
                E1082 = lineNo,
                C212 = new C212()
                {
                    E7140 = code,
                    E7143 = codeType,
                    E3055 = respAgency
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

        public static NAD NAD(string qualf, string gln, string name, string street, string city, string zip,
            string countryCode, string agency = "9")
        {
            string[] nameParts = name.SplitToChunks(35, 5);
            string[] streetParts = street.SplitToChunks(35, 5);
            return new NAD()
            {
                E3035 = qualf,
                C082 = new C082()
                {
                    E3039 = gln,
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

        public static PAI PAI(int paymentType)
        {
            return new PAI()
            {
                C534 = new C534() { E4461 = paymentType.ToString() }
            };
        }

        public static PAT PAT(string qualf)
        {
            return new PAT()
            {
                E4279 = qualf
            };
        }

        public static PAT PAT(string qualf, string paymentTimeReference, string timeRelation, string typeOfPeriod,
            int numberOfPeriods)
        {
            return new PAT()
            {
                E4279 = qualf,
                C112 = new C112()
                {
                    E2475 = paymentTimeReference,
                    E2009 = timeRelation,
                    E2151 = typeOfPeriod,
                    E2152 = numberOfPeriods.ToString()
                }
            };
        }

        public static PIA PIA(string qualf, string itemNo, string itemNoType)
        {
            return new PIA()
            {
                E4347 = qualf,
                C212 = new C212()
                {
                    E7140 = itemNo,
                    E7143 = itemNoType
                }
            };
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

        public static PRI PRI(string qualf, decimal price)
        {
            return PRI(qualf, price, "0.000");

        }

        public static PRI PRI(string qualf, decimal price, string format)
        {
            return new PRI()
            {
                C509 = new C509()
                {
                    E5125 = qualf,
                    E5118 = price.ToString(format, CultureInfo.InvariantCulture)
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
        
        public static QTY QTY(string qualf, string qty, string unitCode)
        {
            return new QTY()
            {
                C186 = new C186()
                {
                    E6063 = qualf,
                    E6060 = qty,
                    E6411 = unitCode
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

        public static RFF RFF(string qualf, string text, string lineNo)
        {
            return new RFF()
            {
                C506 = new C506()
                {
                    E1153 = qualf,
                    E1154 = text,
                    E1156 = lineNo
                }
            };
        }

        public static string[] SplitToChunks(this string text, int chunkSize, int chunks)
        {
            string[] parts = new string[chunks];
            int textPos = 0;
            int part = 0;

            if (string.IsNullOrEmpty(text))
                return parts;

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

        public static TAX TAX(string qualf, string type, string rateId, decimal basis, decimal rate)
        {
            return new TAX()
            {
                E5283 = qualf,
                E5286 = basis.ToString("0.00", CultureInfo.InvariantCulture),
                C241 = new C241() { E5153 = type },
                C243 = new C243()
                {
                    E5279 = rateId,
                    E5278 = rate != 0 ? rate.ToString("0.00", CultureInfo.InvariantCulture) : ""
                }
            };
        }

        public static TAX TAX(string qualf, string type, string rateId, decimal rate)
        {
            return new TAX()
            {
                E5283 = qualf,
                //E5286 = basis.ToString("0.00", CultureInfo.InvariantCulture),
                C241 = new C241() { E5153 = type },
                C243 = new C243()
                {
                    E5279 = rateId,
                    E5278 = rate != 0 ? rate.ToString("0.00", CultureInfo.InvariantCulture) : ""
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


        public static TAX TAX(string qualf, string type, decimal rate, string rateId, string category)
        {
            return new TAX()
            {
                E5283 = qualf,
                C241 = new C241() { E5153 = type },
                C243 = new C243() { E5278 = rate.ToString("0.00", CultureInfo.InvariantCulture), E5279 = rateId },
                E5305 = category
            };
        }

        public static TAX TAX(string qualf, string type, decimal rate, string rateId, decimal basis)
        {
            return new TAX()
            {
                E5283 = qualf, //7
                E5286 = basis.ToString("0.00", CultureInfo.InvariantCulture),
                C241 = new C241() { E5153 = type }, //VAT
                C243 = new C243()
                {
                    E5279 = rateId,
                    E5278 = rate.ToString("0.00", CultureInfo.InvariantCulture)
                }
            };
        }

        public static UNS UNS()
        {
            return new UNS()
            {
                E0081 = "S"
            };
        }

        public static PAC PAC(string noOfPackages, string typeOfPackagesIdentification, string agency)
        {
            return new PAC()
            {
                E7224 = noOfPackages,
                C202 = new C202()
                {
                    E3055 = agency,
                    E7065 = typeOfPackagesIdentification
                },
            };
        }

        public static MEA MEA(string qualf, string dimensionCode, string unit, string value)
        {
            return new MEA()
            {
                E6311 = qualf,
                C502 = new C502()
                {
                    E6313 = dimensionCode
                },
                C174 = new C174()
                {
                    E6411 = unit,
                    E6314 = value
                }
            };
        }

        public static LOC LOC(string qualf, string placeId)
        {
            return new LOC()
            {
                E3227 = qualf,
                C517 = new C517()
                {
                    E3225 = placeId
                }
            };
        }

        public static PCI PCI(string markingInstructions)
        {
            return new PCI()
            {
                E4233 = markingInstructions
            };
        }

        public static GIR GIR(string qualf, string identityNo, string identityNoQualf)
        {
            return new GIR()
            {
                E7297 = qualf,
                C206 = new C206()
                {
                    E7402 = identityNo,
                    E7405 = identityNoQualf
                }
            };
        }
    }
}
