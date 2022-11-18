using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;

namespace WallE.InstrLan.Instructions
{
    public class ColorSensor : Instruction, ISensor
    {
        public void Active(ISensitive robot)
        {
            robot.Color( );
        }

        public override object Clone( )
        {
            return new ColorSensor( );
        }

        public override void Execute(IProgrammable robot)
        {
            if ( robot is ISensitive )
                Active(robot as ISensitive);
            else
                Simulator.Simulator.ReportError(robot,new Errors.Error("Этот программируемый объект не реализует данный датчик."));
        }
        public override string ToString( )
        {
            return "color";
        }
        public override bool Equals(object obj)
        {
            return obj is ColorSensor;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
