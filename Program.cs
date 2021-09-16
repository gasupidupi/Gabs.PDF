using System;
using System.Collections.Generic;

namespace Gabs.PDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var PDF = new PDF();
            var PDFCatalog = new PDFCatalog(1,0);
            var PDFPages = new PDFPages(2,0);
            var PDFPage = new PDFPage(3,0);
            var PDFFont = new PDFFont(4,0);
            var PDFStream = new PDFStream(5,0);

            PDFCatalog.PDFPages = PDFPages;

            PDFPages.Kids = new List<PDFPage>(){ PDFPage };
            PDFPages.Size = new Tuple<int, int>(200, 200);
            PDFPages.Count = 1;

            PDFPage.Parent = PDFPages;
            PDFPage.Resources = new List<PDFObject>(){ PDFFont };
            PDFPage.Contents = PDFStream;

            PDFFont.BaseFont = "Times-Roman";
            PDFFont.Subtype = "Type1";

            PDFStream.Resources = new List<PDFObject>(){ PDFFont };
            PDFStream.Position = new Tuple<int, int>(70, 50);
            PDFStream.Text = "Hello, world!";
            
            var PDFObjects = new List<PDFObject>() {
                PDFCatalog,
                PDFPages,
                PDFPage,
                PDFFont,
                PDFStream
            };
            PDF.AddNewObjects(PDFObjects);
        }
    }
}
