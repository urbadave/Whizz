using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleModels;
public class FivePlaceInputLetter
{
    public char Letter { get; set; }
    public int State { get; set; }  //0 = ruled out, 1 = incorrect place, 2 = correct place

    public FivePlaceInputLetter()
    {
        Letter = '\0';
        State = 0;
    }

    public FivePlaceInputLetter(char letter, int state)
    {
        Letter = letter;
        State = state;
    }

    public FivePlaceInputLetter(string rawInput)
    {
        var trimInput = rawInput.Trim();
        var ltr = trimInput.Substring(0, 1)[0];
        var num = trimInput.Substring(1);
        var state = int.Parse(num);
        Letter = ltr;
        State = state;
    }
}
