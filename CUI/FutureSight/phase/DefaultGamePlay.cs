using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    [Serializable()]
    class DefaultGamePlay : IGamePlay
    {
        private static DefaultGamePlay instance;

        public MagicPhase StartPhase()
        {
            return MulliganPhase.Instance;
        }

        public MagicPhase NextPhase(MagicPhase phase)
        {
            switch (phase.Type)
            {
                case MagicPhaseType.MulliganStep:
                    return UntapStep.Instance;
                case MagicPhaseType.UntapStep:
                    return UpkeepStep.Instance;
                case MagicPhaseType.UpkeepStep:
                    return DrawStep.Instance;
                case MagicPhaseType.DrawStep:
                    return FirstMainPhase.Instance;
                case MagicPhaseType.FirstMainPhase:
                    return PreCombatStep.Instance;
                case MagicPhaseType.PreCombatStep:
                    return DeclareAttackerStep.Instance;
                case MagicPhaseType.DeclareAttackerStep:
                    return DeclareBlockerStep.Instance;
                case MagicPhaseType.DeclareBlockerStep:
                    return CombatDamageStep.Instance;
                case MagicPhaseType.CombatDamageStep:
                    return EndOfCombatStep.Instance;
                case MagicPhaseType.EndOfCombatStep:
                    return SecondMainPhase.Instance;
                case MagicPhaseType.SecondMainPhase:
                    return EndStep.Instance;
                case MagicPhaseType.EndStep:
                    return CleanupStep.Instance;
                case MagicPhaseType.CleanupStep:
                    return UntapStep.Instance;
                default:
                    throw new System.Exception("Unknown Step");
            }
        }

        public static DefaultGamePlay Instance
        {
            get
            {
                if (instance == null) instance = new DefaultGamePlay();
                return instance;
            }
        }
    }
}
