using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDFPages : PDFObject {
    
        public Tuple<int, int> Size { get; set; }
        public int Count { get; set; }
        public List<PDFPage> Kids { get; set; }

        public override int ObjectNumber { get; set; }
        public override int RevisionNumber { get; set; }

        public PDFPages(int ObjectNumber, int RevisionNumber) : base(ObjectNumber, RevisionNumber) {
            this.ObjectNumber = ObjectNumber;
            this.RevisionNumber = RevisionNumber;
        }

    }

}