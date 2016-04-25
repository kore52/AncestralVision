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
                    game.AddEvent(new MagicPriorityEvent(game.Priority.GetPriorityPlayer()));
                    break;
                case MagicStepType.Skip:
                    if (game.Priority.IsPassedAll())
                        if (game.EventQueue.Count == 0)
                            step = MagicStepType.NextPhase;
                        else
                            step = MagicStepType.Resolve;
                    break;
                case MagicStepType.Resolve:
                    step = MagicStepType.ActivePlayer;
                    game.Priority.Clear();
                    game.Resolve();
                    break;
                case MagicStepType.NextPhase:
                    step = MagicStepType.Begin;
                    ExecuteEndStep(game);
                    break;
            } 
        }
    }
}