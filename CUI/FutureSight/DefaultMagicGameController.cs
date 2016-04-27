using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class DefaultMagicGameController : IGameController
    {
        private int InitialLife = 20;
        private int InitialLosePoisonCounter = 10;

        private MagicGame game;

        public void Initialize()
        {
            var player1 = new MagicPlayer();
            var player2 = new MagicPlayer();
            
            game = MagicGame.Create(new List<MagicPlayer>() { player1, player2 }, player1);
        }

        public void RunGame()
        {
            while (game.AdvanceToNextEventWithChoice())
            {
                var priorityPlayer = game.GetPriorityPlayer();

                // TODO:
                // var results = game.GetAIChoiceResults();
            }
        }

        
    }
}
