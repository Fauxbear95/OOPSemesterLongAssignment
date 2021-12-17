using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterLongAssignment
{
    class Enemy
    {
        public string Name { get; set; }
        public int DefenceLevel { get; set; }
        public int StabDefence { get; set; }
        public int SlashDefence { get; set; }
        public int CrushDefence { get; set; }
        public int MagicDefence { get; set; }
        public int RangedDefence { get; set; }

        public Enemy(string name, int defenceLevel, int stabDefence, int slashDefence, int crushDefence, int magicDefence, int rangedDefence)
        {
            Name = name;
            DefenceLevel = defenceLevel;
            StabDefence = stabDefence;
            SlashDefence = slashDefence;
            CrushDefence = crushDefence;
            MagicDefence = magicDefence;
            RangedDefence = rangedDefence;
        }
    }
}
