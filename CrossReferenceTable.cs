using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    /// <summary>
    /// The cross reference table.
    /// </summary>
    class CrossReferenceTable {
    
        /// <summary>
        /// The number it starts counting from to reach the objectsCountLastIndex.
        /// objectsCountLastIndex - objectCountFirstIndex = the amount of objects in the PDF
        /// </summary>
        /// <value>int</value>
        int objectCountFirstIndex { get; set; }

        /// <summary>
        /// The last index of the PDFs internal objects collection.
        /// objectsCountLastIndex - objectCountFirstIndex = the amount of objects in the PDF
        /// </summary>
        /// <value>int</value>
        int objectsCountLastIndex { get; set; }

        /// <summary>
        /// A dictionary containing references to all objects in the PDF.
        /// </summary>
        /// <value>A dictionary </value>
        Dictionary<int, CrossReferenceTableElement> objectsDictionary { get; set; }

    }

}