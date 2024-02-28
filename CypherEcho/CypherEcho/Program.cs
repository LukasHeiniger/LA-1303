using System;
using System.IO;
using System.Diagnostics;



namespace CypherEcho
{
    public class Program
    {
        
        static void Main()
        {
            int lockcode = 0;
            int unlockcode = 0;

            Print printer = new Print();
            Searchfile searchfile = new Searchfile();

            Cypher cypher = new Cypher();
            

            string text = "Du weisst, was zu tun ist.";
            printer.PrintWithDelay(text, 50);

            Space();
            Space();

            string text2 = "Lade die gewünschte Datei hoch, und ich schaue, was ich damit machen kann.";
            printer.PrintWithDelay(text2, 50);

            Space();

            Console.Write("Name der Textdatei: ");
            string dateiName = Console.ReadLine();



            
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, dateiName);

            searchfile.SearchFile(desktopPath, dateiName);

            Console.WriteLine("Suche abgeschlossen.");

            string text3 = "Entschlüssel oder Verschlüsseln: ";
            printer.PrintWithDelay(text3, 50);

            Console.WriteLine("[1/2]");
            int answer =Convert.ToInt32(Console.ReadLine());

            if(answer == 1)
            {
                Space();

                Console.WriteLine("So du möchtest entschlüsseln, wähle deinen Code");

                Space();

                Console.WriteLine("Decode 1");
                int decode1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Code 2");
                int decode2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Code 3");
                int decode3 = Convert.ToInt32(Console.ReadLine());

                unlockcode = decode1 + decode2 + decode3;

                string decryptedText = cypher.Decrypt(File.ReadAllText(filePath), unlockcode);
                File.WriteAllText(filePath, decryptedText);

            }
            else if(answer == 2)
            {
                Space();

                Console.WriteLine("So du möchtest verschlüsseln, wähle deinen Code");
                
                Space();

                Console.WriteLine("Code 1");
                int code1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Code 2"); 
                int code2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Code 3");
                int code3 = Convert.ToInt32(Console.ReadLine());

                lockcode = code1 + code2 + code3;

                string encryptedText = cypher.Encrypt(File.ReadAllText(filePath), lockcode);
                File.WriteAllText(filePath, encryptedText);



            }

            string text4 = "Da wir nun fertig sind solltest du verschwinden, bevor dich noch jemand erwischt.";
            printer.PrintWithDelay(text4, 50);


        }

       

        static void Space()
        {
            Console.WriteLine();
        }


    }
}