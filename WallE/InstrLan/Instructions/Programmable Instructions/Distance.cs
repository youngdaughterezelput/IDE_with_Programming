using System;
using WallE.Tools;

namespace WallE.InstrLan.Instructions
{
    public class Distance : Instruction , ISensor
    {
        public void Active(ISensitive robot)
        {
            robot.Distance( );
        }

        public override object Clone( )
        {
            return new Distance( );
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
            return "distance";
        }
        public override bool Equals(object obj)
        {
            return obj is Distance;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
