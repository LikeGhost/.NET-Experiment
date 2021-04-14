using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPG
{
    class Hero:Spirits
    {
        public Hero(PictureBox PictureBox, Label HeroLabel) : base(PictureBox, HeroLabel)
        {
        }


      

        public void MoveTo(Monster Monster)
        {
            PictureBox.BringToFront();
            int xSpeed = 10;
            while (X + Width <= Monster.X)
            {
                PictureBox.Left = X + xSpeed;
                X += xSpeed;
                Thread.Sleep(10);
            }

            while (X >= OriginalX)
            {
                PictureBox.Left = X - xSpeed;
                X -= xSpeed;
                Thread.Sleep(10);
            }
            X = OriginalX;
            PictureBox.Left = OriginalX;
            int random = new Random().Next(140, 160);
            Monster.HP -= random;
            Monster.HeroLabel.Width -= (int)(random * 1.0 / 1000 * 256);
            Monster.HeroLabel.Left += (int)(random * 1.0 / 1000 * 256);

        }
    }
}
