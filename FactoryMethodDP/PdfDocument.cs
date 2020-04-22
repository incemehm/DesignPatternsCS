namespace FactoryMethodDP
{
    public class PdfDocument : IDocument
    {
        private const string _title = "A_Clockwork_Orange_PDF";
        private const string _content = "PDF:  In 1970..............";

        public string GetDocumentTitle()
        {
            return _title;
        }

        public string GetDocumentContent()
        {
            return _content;
        }
    }
}
