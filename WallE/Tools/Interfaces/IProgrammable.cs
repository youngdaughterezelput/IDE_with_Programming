using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;
using WallE.Simulator;

namespace WallE.Tools
{
    /// <summary>
    /// Представляет поведение любого запрограммированного объекта.
    /// </summary>
    public interface IProgrammable
    {
        LinealMemory Memory { get; set; }
        Stack<int> Stack { get; set; }
        Stack<Proc> ExecutingStack { get; set; }
        ProcList ListRoutine { get; set; }
        int Times { get; set; }
        void Back( );
        void Advance( );
        int Directions { get; set; }
    }
}
