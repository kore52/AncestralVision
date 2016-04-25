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
        public static MagicChoice None;
        public static Collection<object> NoneOfChoiceResults;
        public static Collection<object> PassChoice;
        public virtual Collection<object> GetPlayerChoiceResults(MagicGame game, MagicEvent evnt)
        {
            return NoneOfChoiceResults;
        }

        public virtual Collection<object> GetAIChoiceResults(MagicGame game, MagicEvent evnt)
        {
            return NoneOfChoiceResults;
        }

        static MagicChoice()
        {
            None = new MagicChoice();
            NoneOfChoiceResults = new Collection<object>();
            PassChoice = new Collection<object>();
        }
    }
}
