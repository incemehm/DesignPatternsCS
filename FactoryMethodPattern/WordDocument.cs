using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class WordDocument : IDocument
    {
        private const string _title = "A_Clockwork_Orange_DOC";
        private const string _content = "DOC:  In 1970..............";

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
