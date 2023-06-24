using PulsarModLoader;

namespace Reactor_Negative_Numbers
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Displays negative reactor stability instead of 0 when the stability is below 0";

        public override string Name => "Reactor negative numbers";

        public override string ModID => "reactornegativenumbers";

        public override string HarmonyIdentifier()
        {
            return "id107.reactornegativenumbers";
        }
    }
}
