using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.World.WorldObjects;
using WallE.Tools;

namespace WallE.InstrLan.Instructions
{
    public class Drop : Instruction,IAction
    {
        public override object Clone( )
        {
            return new Drop( );
        }

        public override void Execute(IProgrammable robot)
        {
            if ( robot is ILoader )
                Proceed(robot);
            else
                Simulator.Simulator.ReportError(robot, new Errors.Error("Это скриптовый объект, он не может взаимодействовать или удалять объекты."));
        }

        public void Proceed(IProgrammable robot)
        {
            ( (ILoader) robot ).Drop( );
        }

        public override string ToString( )
        {
            return "drop";
        }
        public override bool Equals(object obj)
        {
            return obj is Drop;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
