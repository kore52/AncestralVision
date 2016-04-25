using System;
using System.Collections.Generic;

namespace FutureSight
{
    [Serializable()]
    public abstract class MagicEvent
    {
        public MagicObject Source;
        public MagicPlayer Controller;
        public List<IMagicTarget> Targets;
        public Action<MagicGame, MagicEvent> Action;
        public MagicChoice Choice;
        public string Text;
        public List<object> ChoiceResults;

        public MagicEvent(
            MagicObject source = null,
            MagicPlayer controller = null,
            List<IMagicTarget> targets = null,
            Action<MagicGame, MagicEvent> action = null,
            MagicChoice choice = null,
            string text = "")
        {
            Source = source ?? MagicObject.None;
            Controller = controller ?? MagicPlayer.None;
            Targets = targets ?? MagicObject.EmptyList;
            Action = action ?? EmptyAction;
            Choice = choice ?? MagicChoice.None;
        }

        public void Execute(MagicGame game, List<object> choiceResults)
        {
            ChoiceResults = choiceResults;
            Action(game, this);
        }

        public static void EmptyAction(MagicGame game, MagicEvent evnt) { }
    }
}