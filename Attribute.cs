using System;

namespace Gabs.PDF
{
    abstract class Attribute {

        public abstract string Label { get; set; }

        public Attribute(string label) {
            this.Label = label;
        }
        
    }
}