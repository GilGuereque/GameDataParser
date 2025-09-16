using GameDataParser.ReadUserInput;

Console.WriteLine("This will be a Game Data Parser project. It will take in a file by you inputting its name and then parse the data.");
Console.WriteLine("Afterwards, it will print out the json from the file that was read.");

// Create an instance of ReadUserInput to call the non-static method
ReadUserInput userInput = new ReadUserInput();
userInput.EnterFileName();

// TODO: Implement file reading and JSON parsing logic
// TODO: Need to implement error handling for file reading and JSON parsing
// TODO: Consider logging errors to a file for later review
// TODO: Will need to print the parsed JSON data to the console in a readable format and to a file possibly

Console.ReadKey();