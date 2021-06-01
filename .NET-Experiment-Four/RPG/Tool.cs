using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
{
    static class Tool
    {

        public static bool IsCrash(Spirits a,Spirits b)
        {
            if (Math.Abs((b.X + b.Width/2) - (a.X+a.Width/2)) <Math.Abs((a.Width + b.Width)/2))
            {
                if (Math.Abs((b.Y + b.Height / 2) - (a.Y + a.Height) / 2)< Math.Abs((a.Height + b.Height) / 2)){
                    return true;
                }
                return false;
            }
            return false;
        }
        public static void LeftBloodReduce(Label HPLabel,int Damage)
        {
            HPLabel.Width -= (int)(Damage * 1.0 / 1000 * 256);
            HPLabel.Left += (int)(Damage * 1.0 / 1000 * 256);

        }
        public static void RightBloodReduce(Label HPLabel, int Damage)
        {
            HPLabel.Width -= (int)(Damage * 1.0 / 1000 * 256);
        }
    }
}
