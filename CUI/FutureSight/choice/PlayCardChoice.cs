using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureSight
{
    public class PlayCardChoice : MagicChoice
    {
        private static PlayCardChoice instance;
        public static PlayCardChoice Instance
        {
            get
            {
                if (instance == null) instance = new PlayCardChoice();
                return instance;
            }
        }

        public override Collection<object> GetPlayerChoiceResults(MagicGame game, MagicEvent evnt)
        {
            Collection<object> results = new Collection<object>();
            return results;
        }

        /// <summary>AIが取り得る選択肢(Options)の一覧を取得</summary>
        public Collection<object> GetAIChoiceOptions(MagicGame game, MagicEvent evnt)
        {
            Collection<object> results = new Collection<object>();
            results.Add(MagicChoice.PassChoice);

            var controller = evnt.Controller;
            var activations = evnt.Source.GetAllActivations();
            foreach (var act in activations)
            {
                if (!act.CanPlay(game)) continue;
                results.Add(act);
            }

            return results;
        }

        public override Collection<object> GetAIChoiceResults(MagicGame game, MagicEvent evnt)
        {
            return GetAIChoiceOptions(game, evnt);
        }
    }

}
