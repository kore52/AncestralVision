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
        public LinkedList<MagicEffect> EventQueue { get; private set; } = new LinkedList<MagicEffect>();
        public MagicStack Stack { get; private set; } = new MagicStack();
        public int ElapsedTurn = 1;
        public MagicPlayer TurnPlayer { get; set; }
        private List<string> LogBook = new List<string>();
        public bool DisableLogging { get; set; } = false;

        public MagicGame(List<MagicPlayer> players, MagicPlayer first)
        {
            Players = players;
            Priority = new MagicPriority(Players, Players[0]);
        }

        public void RunGame()
        {
        }

        public void ExecutePhase()
        {

        }

        public void ExecuteEffect()
        {

        }

        public void Resolve()
        {

        }

        public void NextPhase()
        {

        }

        public static MagicGame Create(List<MagicPlayer> players, MagicPlayer first)
        {
            return new MagicGame(players, first);
        }

        public void Tracelog(string log)
        {
            LogBook.Add(log);
        }

        public void Snapshot()
        {

        }

    }
}
