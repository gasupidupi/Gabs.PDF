using System;

namespace Gabs.PDF {

    public interface PDFObject {

        int ObjectNumber { get; set; }
        int RevisionNumber { get; set; }

    }

}