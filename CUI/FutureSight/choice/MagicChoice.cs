using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class MagicChoice
    {
        public static MagicChoice None = new MagicChoice();
        public static Collection<object> NoneOfChoiceResults = new Collection<object>();
        public static Collection<object> PassChoice = new Collection<object>();

        public virtual Collection<object> GetPlayerChoiceResults(MagicGame game, MagicEvent evnt)
        {
            return NoneOfChoiceResults;
        }

        public virtual Collection<object> GetAIChoiceResults(MagicGame game, MagicEvent evnt)
        {
            return NoneOfChoiceResults;
        }
    }
}
