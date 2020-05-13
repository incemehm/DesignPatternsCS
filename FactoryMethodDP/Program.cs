namespace FactoryMethodDP
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factory = new DocumentFactory();

            IDocument doc = factory.CreateVersion("PDF");
            System.Console.WriteLine(doc.GetDocumentTitle());
            System.Console.WriteLine(doc.GetDocumentContent());

            doc = factory.CreateVersion("DOCX");
            System.Console.WriteLine(doc.GetDocumentTitle());
            System.Console.WriteLine(doc.GetDocumentContent());

        }
    }
}
