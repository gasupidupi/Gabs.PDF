using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDFStream : PDFObject {

        public string Text { get; set; }
        public Tuple<int, int> Position { get; set; }
        public List<PDFObject> Resources { get; set; }
        public override int ObjectNumber { get; set; }
        public override int RevisionNumber { get; set; }

        public PDFStream(int ObjectNumber, int RevisionNumber) : base(ObjectNumber, RevisionNumber) {
            this.ObjectNumber = ObjectNumber;
            this.RevisionNumber = RevisionNumber;
        }
 
    }

}