using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleModels
{
    public class MoveProducer
    {
        public string GameId { get; set; } = string.Empty;
        public int MoveNumber { get; set; } = 0;

        public GameMove MakeMove(string fivePlaceInput)
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

            fivePlaceInput = fivePlaceInput.Replace("=", "");
            var place = 0;
            for (int i = 0; i < 10; i++)
            {
                var str = fivePlaceInput.Substring(i, 2);
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
    }
}
