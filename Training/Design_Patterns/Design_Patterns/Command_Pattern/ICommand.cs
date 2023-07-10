using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    internal interface ICommand
    {
        void Execute();
        void Undo();

    }
}
