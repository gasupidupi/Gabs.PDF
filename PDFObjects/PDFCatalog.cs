using System;

namespace Gabs.PDF {

    public class PDFCatalog : PDFObject {

        public PDFPages PDFPages { get; set; }

        public override int ObjectNumber { get; set; }
        public override int RevisionNumber { get; set; }

        public PDFCatalog(int ObjectNumber, int RevisionNumber) : base(ObjectNumber, RevisionNumber) {
            this.ObjectNumber = ObjectNumber;
            this.RevisionNumber = RevisionNumber;
        }

    }

}