using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP
{
    public class DocumentFactory
    {
        public IDocument CreateVersion(string docType) // Factory Method budur. Nesne yaratma sorumluluğunu alır.
        {
            if (docType.Equals("PDF"))
            {
                return new PdfDocument();
            }
            else if (docType.Equals("DOCX"))
            {
                return new WordDocument();
            }
            else
            {
                throw new Exception("Hatalı Seçim");
            }
        }
    }
}
