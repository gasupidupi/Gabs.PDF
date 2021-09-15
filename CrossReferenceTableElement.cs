using System;

namespace Gabs.PDF {

    /// <summary>
    /// The cross reference table.
    /// </summary>
    class CrossReferenceTableElement {

        int position { get; set; }

        int revisionNumber { get; set; }

        CrossReferenceTableElementMarker marker { get; set; }     

    }

}