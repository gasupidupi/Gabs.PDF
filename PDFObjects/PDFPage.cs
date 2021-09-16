using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDFPage : PDFObject {
    
        public PDFPages Parent { get; set; }
        public List<PDFObject> Resources { get; set; }
        public PDFObject Contents { get; set; }

        public override int ObjectNumber { get; set; }
        public override int RevisionNumber { get; set; }

        public PDFPage(int ObjectNumber, int RevisionNumber) : base(ObjectNumber, RevisionNumber) {
            this.ObjectNumber = ObjectNumber;
            this.RevisionNumber = RevisionNumber;
        }

    }

}