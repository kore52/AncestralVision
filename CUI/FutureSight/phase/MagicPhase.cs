using System;

namespace FutureSight
{
    [Serializable()]
    public abstract class MagicPhase
    {
        public enum MagicStepType
        {
            Begin,
            ActivePlayer,
            Skip,
            Resolve,
            NextPhase
        }

        public virtual MagicPhaseType Type { get; } = MagicPhaseType.Unknown;
        private MagicStepType step;

        public abstract void ExecuteBeginStep(MagicGame game);
        public abstract void ExecuteEndStep(MagicGame game);

        public void ExecutePhase(MagicGame game)
        {
            switch (step)
            {
                case MagicStepType.Begin:
                    game.Priority.Clear();
                    ExecuteBeginStep(game);
                    break;
                case MagicStepType.ActivePlayer:
                    break;
                case MagicStepType.Skip:
                    if (game.Priority.IsPassedAll())
                        step = MagicStepType.Resolve;
                    break;
                case MagicStepType.Resolve:
                    game.Priority.Clear();
                    game.Resolve();
                    break;
                case MagicStepType.NextPhase:
                    ExecuteEndStep(game);
                    break;
            } 
        }
    }
}