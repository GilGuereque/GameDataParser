namespace GameDataParser.ReadUserInput 
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
            var input = Console.ReadLine();
            FileName = input ?? string.Empty;
            FileExt = Path.GetExtension(FileName);
            while (FileExt != ".json")
            {
                Console.WriteLine("Please enter a valid file name:");
                input = Console.ReadLine();
                FileName = input ?? string.Empty;
                FileExt = Path.GetExtension(FileName);
            }
        }
    }
}
