using System;

namespace Gabs.PDF {

    public abstract class PDFObject {

        public abstract int ObjectNumber { get; set; }
        public abstract int RevisionNumber { get; set; }

        public PDFObject(int objectNumber, int revisionNumber) {
            this.ObjectNumber = objectNumber;
            this.RevisionNumber = revisionNumber;
        }

        

    }

}