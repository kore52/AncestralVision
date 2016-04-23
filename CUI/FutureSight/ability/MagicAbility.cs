using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public abstract class MagicAbility : IStackItem
    {
        public MagicObject Source { get; private set; }
        public MagicPlayer Controller { get; private set; }
        public string Text { get; private set; }
        public List<IMagicTarget> Target { get; private set; }

        public abstract bool CanPlay();
    }
}
