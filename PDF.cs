using System;
using System.collection.Generic;

namespace Gabs.PDF {

    class PDF {

        public Header header { get; }
        public CrossReferenceTable crossReferenceTable { get; }
        List<PDFObject> PDFObjects;

        public void AddNewObject(PDFObject PDFObject) {
            PDFObjects.add(PDFObject);
            crossReferenceTable.objectsDictionary.Add(PDFObjects.Count+1, new CrossReferenceTableElement())
        }

    }

}