using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.InstrLan.Instructions;

namespace WallE.InstrLan.InstructionFactory
{
    public class NWFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new NW( );
    }
}
