using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPG
{
    class HolySpirit:Hero
    {

        public HolySpirit(PictureBox PictureBox, Label HPLabel) : base(PictureBox,HPLabel)
        {
            AttackKind = 2;
           
        }
        
        
    }
} 
