using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulRecords;

namespace WordleModels
{
    public class FivePlaceMoveProducer : IMoveProducer
    {
        private string CapLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-";
        private string States = "012";
        public string GameId { get; set; } = string.Empty;
        public int MoveNumber { get; set; } = 0;

        public GameMove MakeMove(string textInput)
        {
            //split on space. turn into array of FivePlaceInputLetters
            var inputList = textInput.Split(' ');

            var fpiList = inputList.Select(i => new FivePlaceInputLetter(i)).ToList();

            GameMove move = GetMove();

            //expect the fpiList to contain exactly 5 letters
            for (int i = 0; i < 5; i++)
            {
                var fpi = fpiList[i];

                if (fpi.Letter == '-') continue;

                switch (fpi.State)
                {
                    case 0:
                        //if there is another input with the same letter with a higher number, then this becomes an status 1 (incorrect)
                        if (ChangeToIncorrectPlacement(fpi, i, fpiList))
                            move.Incorrect[i].Add(fpi.Letter);
                        else
                            move.RuledOut.Add(fpi.Letter);
                        break;
                    case 1:
                        move.Incorrect[i].Add(fpi.Letter);
                        break;
                    case 2:
                        move.Correct[i] = fpi.Letter;
                        break;
                    default:
                        break;
                }
            }

            return move;
        }

        public bool ChangeToIncorrectPlacement(FivePlaceInputLetter fpi, int index, List<FivePlaceInputLetter> fpiList)
        {
            var change = false;
            for(int i = 0; i < 5; i++)
            {
                if (i == index) continue;
                var toCheck = fpiList[i];
                if (toCheck.Letter == fpi.Letter && toCheck.State > fpi.State)
                    change = true;
            }
            return change;
        }

        public void Instructions()
        {
            Console.WriteLine();
            Console.WriteLine("Input the five letters and their type from Wordle. Use -0 to indicate empty wordle boxes.");
            Console.WriteLine("0 means ruled out, 1 means in wrong position, 2 mean in correct position");
        }

        public BoolResponse IsInputValid(string textInput)
        {
            textInput = textInput.Trim();

            if(string.IsNullOrWhiteSpace(textInput))
            {
                return new BoolResponse(false, "Empty text is not valid");
            }

            textInput = textInput.ToUpper();

            var example = "A0 R0 O0 S0 E0";
            if (textInput.Length != example.Length)
            {
                return new BoolResponse(false, $"Input should look like this:{example}");
            }

            //position 2,5,8 and 11 are all spaces
            if (textInput[2] != ' ' || textInput[5] != ' ' || textInput[8] != ' ' || textInput[11] != ' ')
            {
                return new BoolResponse(false, $"Input should look like this:{example}");
            }

            //position 0,3,6,9 and 12 are all letters
            if (!CapLetters.Contains(textInput[0]) || !CapLetters.Contains(textInput[3]) || !CapLetters.Contains(textInput[6]) || !CapLetters.Contains(textInput[9]) || !CapLetters.Contains(textInput[12]))
            {
                return new BoolResponse(false, $"Input should look like this:{example}");
            }

            //position 1,4,7,10 and 13 are all 0, 1 or 2
            if (!States.Contains(textInput[1]) || !States.Contains(textInput[4]) || !States.Contains(textInput[7]) || !States.Contains(textInput[10]) || !States.Contains(textInput[13]))
            {
                return new BoolResponse(false, $"Input should look like this:{example}");
            }

            return new BoolResponse(true, string.Empty);
        }

        private GameMove GetMove()
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
            return move;
        }
    }
}
