
using System.IO;

namespace Server
{
    public class CompareFiles
    {

        public string ReadFile(string pathFile1) //, string pathFile
        {
           
            string readText = File.ReadAllText(pathFile1);

            return readText;
        }


    }
}
