//using GameDataParser.ReadFileData;

//namespace GameDataParser.LegacyCode
//{
//    public class FileNameReader
//    {
//        public string FileName { get; private set; }
//        public string FileExt => Path.GetExtension(FileName);

//        public FileNameReader()
//        {
//            FileName = string.Empty;
//        }

//        public void PromptForFileName()
//        {
//            try
//            {
//                Console.WriteLine("Enter the name of the file you want to read (.json):");
//                var input = Console.ReadLine()?.Trim() ?? string.Empty;
//                FileName = input;
//                if (FileName is not null && )
//                {
//                    fileContents = File.ReadAllText(FileName);
//                    isFileRead = true;
//                }

//            }


//        }
//    }
//}
