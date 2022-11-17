using WallE.InstrLan.Instructions;

namespace WallE.InstrLan.InstructionFactory
{
    public class DropFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Drop( );
    }
}
