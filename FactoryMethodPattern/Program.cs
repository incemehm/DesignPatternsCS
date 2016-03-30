using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory = new DocumentFactory();

            IDocument doc = factory.CreateVersion("PDF");
            Console.WriteLine(doc.GetDocumentTitle());
            Console.WriteLine(doc.GetDocumentContent());

             doc = factory.CreateVersion("DOCX");
            Console.WriteLine(doc.GetDocumentTitle());
            Console.WriteLine(doc.GetDocumentContent());

        }
    }
}
