using System;
using System.Collections;
using System.Collections.Generic;

namespace FutureSight
{
    [Serializable()]
    public class MagicPlayer
    {
        public string Name = "No Name";
        private bool IsAI { get; set; }

        public MagicCardList Hand { get; set; } = new MagicCardList();
        public MagicCardList Graveyard { get; set; } = new MagicCardList();
        public MagicCardList Library { get; set; } = new MagicCardList();
        public MagicCardList Exile { get; set; } = new MagicCardList();
        public MagicCardList Sideboard { get; set; } = new MagicCardList();
        public List<MagicPermanent> Permanents { get; set; } = new List<MagicPermanent>();

        public int Life { get; set; }
        public int MaxHandSize { get; set; }
        public Dictionary<MagicCounterType, int> Counters { get; set; } = new Dictionary<MagicCounterType, int>();
        public List<MagicPlayer> Opponents { get; set; } = new List<MagicPlayer>();

        public static MagicPlayer None = new MagicPlayer();

        public MagicPlayer() { }
        public MagicPlayer(MagicCardList mainboard = null, MagicCardList sideboard = null, int initialLife = 20, int maxHandSize = 7, bool isAI = false)
        {
            Library = mainboard ?? new MagicCardList();
            Sideboard = sideboard ?? new MagicCardList();
            Life = initialLife;
            MaxHandSize = maxHandSize;
            IsAI = isAI;
        }

        public IEnumerable<MagicAbility> GetAllActivations()
        {
            foreach (var c in Hand)
            {
                foreach (var item in c.GetAllActivations())
                {
                    yield return item;
                }
            }
            foreach (var c in Graveyard)
            {
                foreach (var item in c.GetAllActivations())
                {
                    yield return item;
                }
            }
            foreach (var c in Exile)
            {
                foreach (var item in c.GetAllActivations())
                {
                    yield return item;
                }
            }
            foreach (var p in Permanents)
            {
                foreach (var item in p.GetAllActivations())
                {
                    yield return item;
                }
            }
        }
    }
}