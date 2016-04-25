using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    class MagicPriorityEvent : MagicEvent
    {
        private MagicPlayer priorityPlayer;

        public MagicPriorityEvent(MagicPlayer priorityPlayer)
            : base(action: EventAction, choice : PlayCardChoice.Instance)
        {
            this.priorityPlayer = priorityPlayer;
        }

        private static Action<MagicGame, MagicEvent> EventAction;
        
        static MagicPriorityEvent()
        {
            EventAction = (MagicGame game, MagicEvent evnt) =>
            {

            };
        }
    }
}
