using System;

namespace Gabs.PDF {

    /// <summary>
    /// A PDF string object.
    /// </summary>
    public class PDFString : PDFObject {

        string content { get; set; }

        public PDFString(string content) {
            this.content = content;
        }

    }

}