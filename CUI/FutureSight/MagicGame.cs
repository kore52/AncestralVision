using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    [Serializable()]
    public class MagicGame
    {
        public IGamePlay GamePlay { get; private set; } = new DefaultGamePlay();
        public MagicPhase Phase { get; private set; } = DefaultGamePlay.Instance.StartPhase();
        public MagicPriority Priority { get; private set; }
        public List<MagicPlayer> Players { get; private set; }
        public LinkedList<MagicEvent> EventQueue { get; private set; } = new LinkedList<MagicEvent>();
        public MagicStack Stack { get; private set; } = new MagicStack();
        public int ElapsedTurn = 1;
        public MagicPlayer TurnPlayer { get; set; }
        private List<string> LogBook = new List<string>();
        public bool DisableLogging { get; set; } = false;

        public MagicGame() { }
        public MagicGame(List<MagicPlayer> players, MagicPlayer first)
        {
            Players = players;
            TurnPlayer = first;
            Priority = new MagicPriority(Players, first);
        }

        public void ExecutePhase()
        {
            Phase.ExecutePhase(this);
        }

        public void NextPhase()
        {
            GamePlay.NextPhase(Phase);
        }

        public void AddEvent(MagicEvent evnt)
        {
            EventQueue.AddLast(evnt);
        }

        public void ExecuteEvent()
        {
            if (EventQueue.Count == 0) throw new Exception("event is empty.");
            var evnt = EventQueue.First();
            EventQueue.RemoveFirst();
            evnt.Execute(this, MagicChoice.NoneOfChoiceResults);
        }

        public void Resolve()
        {
        }

        public bool AdvanceToNextEventWithChoice()
        {
            while (true)
            {
                if (EventQueue.Count == 0)
                {
                    ExecutePhase();
                }
                else
                {
                    var evnt = EventQueue.First();
                    if (evnt.Choice == MagicChoice.None)
                    {
                        ExecuteEvent();
                        return false;
                    }
                    else
                    {
                        ExecuteEvent();
                        return true;
                    }
                }
            }
        }

        public void Tracelog(string log)
        {
            LogBook.Add(log);
        }

        public void Snapshot()
        {

        }

        public MagicPlayer GetPriorityPlayer()
        {
            return Priority.GetPriorityPlayer();
        }

        public static MagicGame Create(List<MagicPlayer> players, MagicPlayer first)
        {
            return new MagicGame(players, first);
        }

    }
}
