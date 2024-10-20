using System.Text;
using WordleModels;

namespace Whizz;

internal class Program
{
    public static WordSifter Sifter { get; private set; }
    public static GameMove Move { get; private set; } = null;
    public static MoveProducer Producer { get; private set; }

    static void Main(string[] args)
    {
        
        Console.WriteLine("Wordle Whizz");
        var CommonWords = new List<string>();
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
                    CommonWords = text.Split("\r\n").ToList();
                }
            }
            Console.WriteLine($"Loaded file with {CommonWords.Count} common 5 letter words");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }

        Sifter = new WordSifter();
        Sifter.LoadWords(CommonWords);
        Producer = new MoveProducer();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Input guess results. Start with =, then each letter followed by result.");
            Console.WriteLine("/ means ruled out, ! means in right position, ? mean in wrong position");

            var userInput = Console.ReadLine();
            
            if (DoWhatTheyAsk(userInput) == null) return;
        }
    }

    public static string? DoWhatTheyAsk(string input)
    {
        if (input == null || input == string.Empty) return null;

        if (input[0] == '=')
        {
            //create a Move with the string.
            Console.WriteLine($"Look for words from move {input}");
            return DoAGameMove(input);
        }

        return "What?";
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
