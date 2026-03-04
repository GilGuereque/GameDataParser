using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GameDataParser.ReadUserInput;

namespace GameDataParser.ReadFileData
{
    internal class FileDataReader
    {
        public FileDataReader()
        {
            var fileNameReader = new FileNameReader();

            fileNameReader.PromptForFileName();

            string fileName = fileNameReader.FileName;
            string fileExtension = fileNameReader.FileExt;

            string fileContents = File.ReadAllText(fileName);

            List<VideoGame>? videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            if (videoGames == null)
            {
                throw new InvalidOperationException("Failed to deserialize video games from file.");
            }
            else if (videoGames.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Loadedgames are:");
                foreach(var videoGame in videoGames)
                {
                    Console.WriteLine(videoGames);
                }
            }
            else
            {
                Console.WriteLine("No games are present in the input file.");
            }

        }

    }

    public class VideoGame
    {
        public string Title { get; init; }
        public int ReleaseYear { get; init; }
        public decimal Rating { get; init; }

        public override string ToString() =>
            $"{Title}, released in {ReleaseYear}, rating: {Rating}";
    }
}
