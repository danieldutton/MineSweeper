using Swinesweeper.Utilities.Interfaces;
using System.Xml.Linq;

namespace Swinesweeper.Utilities
{
    public class XDocumentLoader : IXDocumentLoader
    {
        public XDocument LoadXDocument(string filePath)
        {
            XDocument xDocument = XDocument.Load(filePath);

            return xDocument;
        }
    }
}
