using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherEcho
{
    public class Searchfile
    {

    

        public void SearchFile(string directory, string fileName)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directory, fileName))
                {

                    Console.WriteLine($"Die Datei {fileName} wurde im Verzeichnis {directory} gefunden.");
                }

                foreach (string subDirectory in Directory.GetDirectories(directory))
                {

                    SearchFile(subDirectory, fileName);
                }


            }
            catch (UnauthorizedAccessException)
            {
               
            }
        }

    }

   
}


