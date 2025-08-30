using GameDataParser.ReadUserInput;

Console.WriteLine("This will be a Game Data Parser project. It will take in a file by you inputting its name and then parse the data.");
//Console.WriteLine("Please enter the name of the file: ");

// Create an instance of ReadUserInput to call the non-static method
ReadUserInput userInput = new ReadUserInput();
userInput.EnterFileName();

Console.ReadKey();