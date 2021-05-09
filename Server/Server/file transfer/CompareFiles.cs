
using System.IO;

namespace Server
{
    public class CompareFiles
    {

        public string ReadFile(string pathFile1) //, string pathFile
        {
            string readText = null;
            try
            {
                 readText = File.ReadAllText(pathFile1);
                
            }
            catch (System.Exception)
            {
                readText = "Podano nieprawidłową ścieżkę";
            }

            return readText;
        }


    }
}
