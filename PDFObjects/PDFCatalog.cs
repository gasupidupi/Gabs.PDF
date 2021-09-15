using System;

namespace Gabs.PDF {

    public class PDFCatalog : PDFObject {

        public PDFPages PDFPages { get; set; }

        public int ObjectNumber { get; set; }
        public int RevisionNumber { get; set; }

    }

}