using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class MagicPermanent : MagicObject
    {
        public MagicCard Data { get; set; }

        public MagicPlayer Owner { get; set; }
        public List<MagicPermanentType> PermanentType { get; set; }
        public List<MagicPermanentState> PermanentState { get; set; }

    }

    public class MagicPermanentFactory
    {
        public static MagicPermanent Create(MagicCard data)
        {
            var card = new MagicPermanent();
            card.Data = data;
            return card;
        }
    }
}
