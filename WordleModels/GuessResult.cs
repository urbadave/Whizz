using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleModels
{
    public enum PositionResuls { SET, INCLUDED, RULEDOUT }

    public class GuessPosition
    {
        public char Letter { get; set; }
        public PositionResuls Result { get; set; } = PositionResuls.RULEDOUT;
    }

    
    public class GuessResult
    {
        public GuessPosition[] Positions { get; set; } = new GuessPosition[5];
    }

}
