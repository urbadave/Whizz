using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulRecords;

namespace WordleModels;
public class CategoryMoveProducer : IMoveProducer
{
    public string GameId { get; set; } = string.Empty;
    public int MoveNumber { get; set; } = 0;

    public GameMove MakeMove(string textInput)
    {
        GameMove move = null;
        if (GameId == string.Empty)
        {
            move = new GameMove();
            GameId = move.GameId;
            MoveNumber = move.MoveNumber;
        }
        else
        {
            MoveNumber++;
            move = new GameMove(GameId) { MoveNumber = MoveNumber };
        }

        var categories = textInput.Split('|');
        if(categories.Length < 3)
        {
            throw new ArgumentException($"{textInput} does not contain 3 categories");
        }

        var ruledOutCategory = categories[0].ToCharArray();
        var incorrectCategory = categories[1];
        var correctCategory = categories[2].ToCharArray();

        move.RuledOut.AddRange(ruledOutCategory);

        if (!string.IsNullOrWhiteSpace(incorrectCategory))
        {
            var incorrectLetters = incorrectCategory.Split(",");
            for (int i = 0; i < incorrectLetters.Length; i++)
            {
                var letter = incorrectLetters[i][0];
                var placeChar = $"{incorrectLetters[i][1]}";
                var placeInt = int.Parse(placeChar)-1;
                move.Incorrect[placeInt].Add(letter);
            }
        }

        for(int i = 0; i < correctCategory.Length; i++)
        {
            if (correctCategory[i] != '_')
            {
                move.Correct[i] = correctCategory[i];
            }
        }

        return move;
    }

    public void Instructions()
    {
        Console.WriteLine();
        Console.WriteLine("Input in 3 segments separated by | character.");
        Console.WriteLine("RuledOut|IncorrectPlace|Correct(_)");
    }

    public BoolResponse IsInputValid(string textInput)
    {
        if (string.IsNullOrWhiteSpace(textInput))
        {
            return new BoolResponse(false, "Empty text is not valid");
        }
        var categories = textInput.Split("|");
        if(categories.Length != 3)
        {
            return new BoolResponse(false, "Must have 3 segments separated by |");
        }

        if (!string.IsNullOrWhiteSpace(categories[1]))
        {
            var incorrect = categories[1].Split(",").ToList();
            if (incorrect.Any())
            {
                foreach (var item in incorrect)
                {
                    if(string.IsNullOrEmpty(item) || item.Length != 2)
                    {
                        return new BoolResponse(false, "Incorrect segment must contain Lette+Number combos only");
                    }
                }
            }
        }

        if (string.IsNullOrWhiteSpace(categories[2]))
        {
            return new BoolResponse(false, "Correct letter segment must be 5 letters long. Use _ for unknowns");
        }

        return new BoolResponse(true, string.Empty);
    }
}
