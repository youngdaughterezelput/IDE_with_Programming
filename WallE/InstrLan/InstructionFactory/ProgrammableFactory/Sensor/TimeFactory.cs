using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WallE.InstrLan.Instructions;
using System.Threading.Tasks;

namespace WallE.InstrLan.InstructionFactory
{
    public class TimeFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Chronometer( );
    }
}
