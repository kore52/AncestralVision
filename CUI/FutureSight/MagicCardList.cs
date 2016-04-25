using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class MagicCardList : Collection<MagicObject>
    {
        public MagicCardList()
        {
        }

        public MagicCardList(IList<MagicObject> list) : base(list)
        {
        }

        public void Shuffle()
        {
            Shuffle(1);
        }

        public void Shuffle(int seed)
        {
            var oldList = new MagicCardList(this);
            var rnd = new Random(seed);
            Clear();
            for (int size = Count; size > 0; size--)
            {
                int index = rnd.Next(size);
                Add(oldList[index]);
                oldList.RemoveAt(index);
            }
        }
    }
}
