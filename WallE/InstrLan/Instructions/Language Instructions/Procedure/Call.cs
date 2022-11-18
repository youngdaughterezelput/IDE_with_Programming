using System;
using WallE.Errors;
using WallE.Rout;
using WallE.Tools;

namespace WallE.InstrLan.Instructions
{
    public class Call : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            int indexRoutine = 0;
            try { indexRoutine = robot.Stack.Pop( ); }
            catch ( Exception )
            {
                Error error = new Error("Пустой стек, поэтому невозможно получить индекс для подпрограммы.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                return;
            }
            if ( robot.ListRoutine.Count - 1 < indexRoutine )
            {
                Error error = new Error("Этот индекс недействителен в списке подпрограмм.");
                if ( Simulator.Simulator.NoAllowErrors )
                {
                    Simulator.Simulator.ReportError(robot,error);
                    return;
                }
                WallE.Simulator.WallE_Console.Print(robot,error.Message);
                return;
            }
            Proc routineCall = (Proc) robot.ListRoutine[indexRoutine].Clone( );
            routineCall.RobotRut = robot;

            try
            {
                robot.ExecutingStack.Push(routineCall);
            }
            catch ( Exception )
            {
                Errors.Error.ReportError(robot,new Error("Стек выполнения заполнен."));
            }

            routineCall.Executing = true;
            if ( Simulator.Round.IsExecutingByInstruction )
                routineCall.ExecuteByInstruction( );
            else
                routineCall.Execute( );
            if ( !robot.ExecutingStack.Peek( ).Executing )
                robot.ExecutingStack.Pop( );
        }
        public override object Clone( )
        {
            return new Call( );
        }
        public override string ToString( )
        {
            return "call";
        }
        public override bool Equals(object obj)
        {
            return obj is Call;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
