using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class DeclareAttackerStep : MagicPhase
    {
        private static MagicPhase instance;
        public static MagicPhase Instance
        {
            get
            {
                if (instance == null) instance = new DeclareAttackerStep();
                return instance;
            }
        }

        public override MagicPhaseType Type { get; } = MagicPhaseType.DeclareAttackerStep;

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
