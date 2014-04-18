using System.Xml.Linq;

namespace Swinesweeper.Utilities.Interfaces
{
    public interface IXDocumentLoader
    {
        XDocument LoadXDocument(string filePath);
    }
}
