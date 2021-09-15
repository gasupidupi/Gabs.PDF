using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDFPages {
    
        public int Width { get; set; }
        public int Height { get; set; }
        public int Count { get; set; }
        public List<PDFPage> Kids { get; set; }

    }

}