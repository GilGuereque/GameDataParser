using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser
{
    public class ReadUserInput
    {
        public string FileName { get; set; }
        public string FileExt { get; set; }

        public ReadUserInput()
        {
            
        }

        public void EnterFileName()
        {

            Console.WriteLine("Enter the name of the file you want to read: ");
            FileName = Console.ReadLine();
            FileExt = Path.GetExtension(FileName);
            if (FileExt != ".json")
            {
                Console.WriteLine("Please enter a valid file name:");
                FileName = Console.ReadLine();
            }
            else
            {

            }

        }
    }
}
