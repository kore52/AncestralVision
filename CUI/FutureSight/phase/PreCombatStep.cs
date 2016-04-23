using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class PreCombatStep : MagicPhase
    {
        private static MagicPhase instance;
        public static MagicPhase Instance
        {
            get
            {
                if (instance == null) instance = new PreCombatStep();
                return instance;
            }
        }

        public override MagicPhaseType Type { get; } = MagicPhaseType.PreCombatStep;

        public override void ExecuteBeginStep(MagicGame game)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteEndStep(MagicGame game)
        {
            throw new NotImplementedException();
        }
    }
}
