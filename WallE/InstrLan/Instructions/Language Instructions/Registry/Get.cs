using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;
using WallE.Tools;

namespace WallE.InstrLan.Instructions
{
    public abstract class Get : Instruction
    {
        public override void Execute(IProgrammable robot)
        {
            GetByChar(robot,robot.ExecutingStack.Peek());
        }
        protected abstract void GetByChar(IProgrammable robot,Proc routine);
    }
}
