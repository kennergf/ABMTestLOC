using System;
using System.Collections.Generic;
using System.Linq;

namespace ABMTestLOC
{
    public class ReadEDIFACT
    {
        private string _EDIFACTData;
        public ReadEDIFACT(string EDIFACTData)
        {
            _EDIFACTData = EDIFACTData;
        }

        public List<string> GetLOCSegments()
        {
            var result = new List<string>();
            //Make sure the segment are clean before work on it
            Utils.ClearNewLine(ref _EDIFACTData);
            var segments =_EDIFACTData.Split("'");
            segments = segments.Where(segment => segment.StartsWith("LOC")).ToArray();
            foreach (var segment in segments)
            {
                var segmentSplited = segment.Split("+");
                result.Add(segmentSplited[1]);
                result.Add(segmentSplited[2]);
            }

            return result;
        }
    }
}