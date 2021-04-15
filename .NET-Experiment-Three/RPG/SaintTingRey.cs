using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    class SaintTingRey : Hero
    {
        public SaintTingRey(PictureBox PictureBox, Label HeroLabel) : base(PictureBox, HeroLabel)
        {
            AttackKind = 1;
        }
    }
}
