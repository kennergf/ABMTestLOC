using System;

namespace ABMTestLOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to read the EDIFACT message!");
            Console.ReadLine();

            var EDIFACTMessage = @"UNA:+.? '
UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-IE++1++1'
UNH+EDIFACT+CUSDEC:D:96B:UN:145050'
BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z'
LOC+17+IT044100'
LOC+18+SOL'
LOC+35+SE'
LOC+36+TZ'
LOC+116+SE003033'
DTM+9:20090527:102'
DTM+268:20090626:102'
DTM+182:20090527:102'";

            var readEDIFACT = new ReadEDIFACT(EDIFACTMessage);
            var result = readEDIFACT.GetLOCSegments();
            if(result.Count > 0)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None LOC segment found!");
            }
        }
    }
}
