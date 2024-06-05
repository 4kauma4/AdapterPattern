using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGameLibray
{
    public interface PCGame
    {
        string GetTitle();
        int GetPegiAllowedAge();
        bool IsTripleAGame();
        Requirements GetRequirements();
    }
}
