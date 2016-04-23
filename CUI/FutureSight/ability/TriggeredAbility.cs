using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class TriggeredAbility : MagicAbility
    {
        // 誘発条件
        public MagicCondition TriggeredCondition;

        public override bool CanPlay()
        {
            throw new NotImplementedException();
        }
    }
}
