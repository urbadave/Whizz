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

        public GameMove MakeMove2(string textInput)
        {
            GameMove move = GetMove();

            textInput = textInput.Replace("=", "");
            var place = 0;
            for (int i = 0; i < 10; i++)
            {
                var str = textInput.Substring(i, 2);
                i++;

                if (str[1] == '/')
                {
                    move.RuledOut.Add(str[0]);
                }
                else if (str[1] == '!')
                {
                    move.Correct[place] = str[0];
                }
                else if (str[1] == '?')
                {
                    move.Incorrect[place].Add(str[0]);
                }

                place++;
            }

            return move;
        }

        public void Instructions()
        {
            Console.WriteLine();
            Console.WriteLine("Input guess results. Start with =, then each letter followed by result.");
            Console.WriteLine("/ means ruled out, ! means in right position, ? mean in wrong position");
        }

        public BoolResponse IsInputValid(string textInput)
        {
            if(string.IsNullOrWhiteSpace(textInput))
            {
                return new BoolResponse(false, "Empty text is not valid");
            }
            if (textInput[0] != '=')
            {
                return new BoolResponse(false, "Must begin with '='");
            }
            var check = textInput.Replace("=", "");
            
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
