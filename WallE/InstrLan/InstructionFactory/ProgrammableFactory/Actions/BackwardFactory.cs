using WallE.InstrLan.Instructions;

namespace WallE.InstrLan.InstructionFactory
{
    public class BackwardFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Backward( );
    }
}
