using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDFPage {
    
        public PDFPages Parent { get; set; }
        public List<PDFObject> Resources { get; set; }
        public PDFObject Contents { get; set; }

    }

}