using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    [Serializable]
    class SoundBox
    {
        [NonSerialized]
        public SoundPlayer loserPlayer = new SoundPlayer(Reversi.Properties.Resources.loser);
        [NonSerialized]
        public SoundPlayer winnerPlayer = new SoundPlayer(Reversi.Properties.Resources.winner);
        [NonSerialized]
        public SoundPlayer errorPlayer = new SoundPlayer(Reversi.Properties.Resources.error);
        [NonSerialized]
        public SoundPlayer placePlayer = new SoundPlayer(Reversi.Properties.Resources.place);
        [NonSerialized]
        public SoundPlayer reversePlayer = new SoundPlayer(Reversi.Properties.Resources.reverse);
        [NonSerialized]
        public SoundPlayer themePlayer = new SoundPlayer(Reversi.Properties.Resources.theme);
    }
}
