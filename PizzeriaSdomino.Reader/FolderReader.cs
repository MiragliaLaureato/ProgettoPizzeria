using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzeriaSdomino.Reader
{
    public static class FolderReader
    {
        //prende tutti i file all'interno di una folder e ne mantiene una lista
        public static IEnumerable<string> GetAllFilePath(string sourcepathdirectory) => new DirectoryInfo(sourcepathdirectory).GetFiles().Select(x => x.FullName);
    }

}
