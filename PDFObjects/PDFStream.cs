using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDFStream {

        int Length { get; set; }
        string[] Filter { get; set; }
        Dictionary<int, string>[] DecodeParams { get; set; }
        string F { get; set; }
        string[] FFilter { get; set; }
        Dictionary<int, string>[] FDecodeParms { get; set; }
        int DL { get; set; }
        public List<PDFObject> Resources { get; set; }
 
    }

}