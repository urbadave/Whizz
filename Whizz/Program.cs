using System.Text;
using WordleModels;

namespace Whizz;

internal class Program
{
    public static WordSifter Sifter { get; private set; }
    public static GameMove Move { get; private set; } = null;
    public static IMoveProducer Producer { get; private set; }

    static void Main(string[] args)
    {        
        Console.WriteLine("Wordle Whizz");
        var commonWords = new List<string>();
        string filePath = string.Empty;
        try
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            if (!string.IsNullOrEmpty(dir))
            {
                filePath = Path.Combine(dir, "FiveLetterWords.txt");
            }
            Console.WriteLine($"Word file path is {filePath}");

            if (File.Exists(filePath))
            {
                //AllWords.Clear();
                using (var reader = new StreamReader(filePath))
                {
                    var text = reader.ReadToEnd();
                    commonWords = text.Split("\r\n").ToList();
                }
            }
            Console.WriteLine($"Loaded file with {commonWords.Count} common 5 letter words");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }

        InitializeGame(commonWords);

        while (true)
        {
            Producer.Instructions();

            var userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
                return;

            if (userInput == "RESET")
            {
                InitializeGame(commonWords);
                Console.WriteLine("Resetting");
                Console.WriteLine();
            }
            else
            {
                var validCheck = Producer.IsInputValid(userInput);
                if (validCheck.response == true)
                {
                    if (DoWhatTheyAsk(userInput) == null)
                        return;
                }
                else
                {
                    Console.WriteLine(validCheck.message);
                }
            }
        }
    }

    public static void InitializeGame(List<string> commonWords)
    {
        Move = null;
        Sifter = new WordSifter();
        Sifter.LoadWords(commonWords);
        //Producer = new FivePlaceMoveProducer();
        Producer = new CategoryMoveProducer();
    }

    public static string? DoWhatTheyAsk(string input)
    {
        if (input == null || input == string.Empty) return null;

        //create a Move with the string.
        Console.WriteLine($"Look for words from move {input}");
        return DoAGameMove(input);

        //return "What?";
    }

    public static string? DoAGameMove(string input)
    {
        var newMove = Producer.MakeMove(input);
        if (Move == null)
        {
            Move = newMove;
        }
        else {
            Move.Merge(newMove);
        }
        Sifter.ApplyGameMove(Move);

        var wordList = Sifter.CandidateWords;
        var outputList = FormatWordOutput(wordList);

        Console.WriteLine("Possible words");
        foreach (var line in outputList)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine();
        Console.WriteLine(Sifter.ScoredLetters());
        Console.WriteLine();

        return $"Move {Move.MoveNumber}";
    }
    

    public static List<string> FormatWordOutput(List<string> wordList)
    {
        List<string> retVal = new();
        var totalCount = wordList.Count;
        var count = wordList.Count;
        var index = 0;
        var cols = 10;

        while (count > 0)
        {
            StringBuilder sb = new();
            var max = index + cols;
            var space = "";
            for (var i = index; i < max; i++)
            {
                if (i < totalCount)
                {
                    sb.Append($"{space}{wordList[i]}");
                    space = "   ";
                }
            }
            retVal.Add(sb.ToString());
            index += cols;
            count -= cols;
        }
        return retVal;
    }
}
