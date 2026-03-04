using GameDataParser.ReadUserInput;

Console.WriteLine("This project will be a Game Data parser. It will take in the file that you input and then parse the data within.");
Console.WriteLine("Afterwards, it will print out the json data from the file that was read.");

// Create an instance of ReadUserInput to call the non-static method
FileNameReader userInput = new FileNameReader();
userInput.PromptForFileName();

// TODO: Implement file reading and JSON parsing logic
// TODO: Need to implement error handling for file reading and JSON parsing
// TODO: Consider logging errors to a file for later review
// TODO: Will need to print the parsed JSON data to the console in a readable format and to a file possibly

Console.ReadKey();

// End of Program.cs (testing remote commit history).