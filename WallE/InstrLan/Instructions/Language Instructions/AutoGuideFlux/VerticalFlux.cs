using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.Rout;

namespace WallE.InstrLan.Instructions
{
    public class VerticalFlux : Instruction, IControlFlux
    {
        public override object Clone( ) => new VerticalFlux( );

        public void Control(Proc routine) { }

        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override string ToString( ) => "verticalFlux";
        public override bool Equals(object obj)
        {
            return obj is VerticalFlux;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
