using GameDataParser.ReadUserInput;

var app = new GameDataParserApp();

try
{
    app.Run();
}
catch(Exception ex)
{
    Console.WriteLine(
        "Sorry! The application has experience an unexpected error " +
        "and will have to be closed." +
        $"{ex.Message}");
}

Console.WriteLine("Press any key to close the app.");
Console.ReadKey();
// End of program

public class GameDataParserApp
{
    public void Run()
    {
        Console.WriteLine("This project will be a Game Data parser. \nIt will take in the file that you input and then parse the data within.");
        Console.WriteLine("\nAfterwards, it will print out the json data from the file that was read.\n");

        // Create an instance of ReadUserInput to call the non-static method
        FileNameReader userInput = new FileNameReader();
        userInput.PromptForFileName();
    }
}

// TODO: Implement file reading and JSON parsing logic
// TODO: Need to implement error handling for file reading and JSON parsing
// TODO: Consider logging errors to a file for later review
// TODO: Will need to print the parsed JSON data to the console in a readable format and to a file possibly