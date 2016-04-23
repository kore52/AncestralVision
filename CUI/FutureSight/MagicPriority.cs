using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FutureSight
{
    [Serializable()]
    public class MagicPriority
    {
        private List<MagicPlayer> Players;
        private int priority;
        private List<bool> passed = new List<bool>();

        public MagicPriority(List<MagicPlayer> players, MagicPlayer first)
        {
            Players = players;
            for ( int i=0; i < players.Count; i++)
                if (players[i].Equals(first)) priority = i;
        }

        public void SetNumberOfPlayers(int num)
        {
            passed.Clear();
            for (int i = 0; i < num; i++) passed.Add(false);
        }

        public void Clear()
        {
            passed.ForEach(p => { p = false; });
        }

        public MagicPlayer GetPriorityPlayer()
        {
            return Players[priority];
        }

        public MagicPlayer NextPlayer()
        {
            if (IsPassedAll()) throw new Exception("all player already passed priority.");
            priority = (priority >= Players.Count) ? priority + 1 : 0;
            return GetPriorityPlayer();
        }

        public void Passed()
        {
            passed[priority] = true;
        }

        public bool IsPassedAll()
        {
            return !passed.Contains(false);
        }
    }
}