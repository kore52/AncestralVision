using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FutureSight;

namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new DefaultMagicGameController();
            controller.Initialize();
            controller.RunGame();
        }
    }
}
