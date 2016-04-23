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
        public List<MagicEffect> Effects { get; set; } = new List<MagicEffect>();
        public string ActivationRestriction { get; set; }

        public override bool CanPlay()
        {
            throw new NotImplementedException();
        }
    }
}
