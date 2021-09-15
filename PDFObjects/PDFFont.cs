using System;

namespace Gabs.PDF {

    public class PDFFont : PDFObject {
    
        public int ObjectNumber { get; set; }
        public int RevisionNumber { get; set; }
        public string Subtype { get; set; }
        public string BaseFont { get; set; }

    }

}