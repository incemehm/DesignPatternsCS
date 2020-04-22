using System;

namespace FactoryMethodDP
{
    public class DocumentFactory
    {
        public IDocument CreateVersion(string docType) //Factory method
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
                throw new Exception("Wrong Choice!");
            }
        }
    }
}
