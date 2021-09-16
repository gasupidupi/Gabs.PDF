using System;
using System.Collections.Generic;

namespace Gabs.PDF {

    public class PDF {

        public Header Header { get; }
        private CrossReferenceTable crossReferenceTable;
        private List<PDFObject> PDFObjects;

        public void AddNewObject(PDFObject PDFObject) {
            PDFObjects.Add(PDFObject);
        }

        public void AddNewObjects(List<PDFObject> PDFObjects) {
            PDFObjects.AddRange(PDFObjects);
        }

    }

}