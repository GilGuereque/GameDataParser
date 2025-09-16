namespace GameDataParser.ReadUserInput
{
    public class ReadUserInput
    {
        public string FileName { get; private set; }
        public string FileExt => Path.GetExtension(FileName);

        public ReadUserInput()
        {
            FileName = string.Empty;
        }

        public void EnterFileName()
        {
            do
            {
                Console.WriteLine("Enter the name of the file you want to read (.json):");
                var input = Console.ReadLine()?.Trim() ?? string.Empty;
                FileName = input;
                if (FileExt != ".json")
                {
                    Console.WriteLine("Invalid file extension. Please enter a valid .json file name.");
                }
            } while (FileExt != ".json");

            // TODO: Log exceptions ?
        }
    }
}
