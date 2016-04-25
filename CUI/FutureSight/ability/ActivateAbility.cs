using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class ActivateAbility : MagicAbility
    {
        public List<IMagicTarget> Targets { get; set; } = new List<IMagicTarget>();
        public List<MagicEvent> Effects { get; set; } = new List<MagicEvent>();
        public string ActivationRestriction { get; set; }

        public override bool CanPlay()
        {
            throw new NotImplementedException();
        }
    }
}
