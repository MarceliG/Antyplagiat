using System;
using System.IO;
using System.Text;

namespace Server
{
    public class FileResult
    {
        static public void CreateFile(string result)
        {
            DateTime day = DateTime.Now;
            string fileName = "Wynik_" + day.Hour.ToString() + "_" + day.Minute.ToString() + "_" + day.Second.ToString() + ".txt";

            string path = Directory.GetCurrentDirectory();
            path += @"\" + fileName;

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(result);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Awaria w FileResult" + ex.ToString());
            }

        }

    }
}

