using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public interface IGamePlay
    {
        MagicPhase StartPhase();
        MagicPhase NextPhase(MagicPhase current);
    }
}
