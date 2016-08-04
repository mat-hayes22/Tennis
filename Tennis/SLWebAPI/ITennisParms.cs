using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLWebAPI
{
    public interface ITennisParms
    {
        int Player1Score { get; }
        int Player2Score { get; }
        string Player1Name { get; }
        string Player2Name { get; }
        int whichPlayer { get; }

    }
}
