using System;

namespace Gabs.PDF {

    public class PDFFont : PDFObject {
    
        public string Subtype { get; set; }
        public string BaseFont { get; set; }

        public override int ObjectNumber { get; set; }
        public override int RevisionNumber { get; set; }

        public PDFFont(int ObjectNumber, int RevisionNumber) : base(ObjectNumber, RevisionNumber) {
            this.ObjectNumber = ObjectNumber;
            this.RevisionNumber = RevisionNumber;
        }


    }

}