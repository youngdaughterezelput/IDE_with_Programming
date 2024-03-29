﻿using WallE.Tools;
using WallE.Rout;
using System;

namespace WallE.InstrLan.Instructions
{

    //старт
    public class Start : Instruction, IControlFlux
    {
        public override void Execute(IProgrammable robot)
        {
            Control(robot.ExecutingStack.Peek( ));
        }
        public override string ToString( )
        {
            return "start";
        }
        public override object Clone( )
        {
            return new Start();
        }
        public void Control(Proc routine)
        {
            routine.Executing = true;
            routine.Body.Flux.Direction = 2;
        }
        public override bool Equals(object obj)
        {
            return obj is Start;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }

}
