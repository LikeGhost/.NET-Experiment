using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPG
{
    class HolySpirit
    {

        public HolySpirit(PictureBox pictureBox,Label HPLabel)
        {
            this.x = pictureBox.Location.X;
            this.y = pictureBox.Location.Y;
            this.originalX = pictureBox.Location.X;
            this.originalY = pictureBox.Location.Y;
            this.width = pictureBox.Width;
            this.height = pictureBox.Height;
            this.pictureBox = pictureBox;
            this.HPLabel = HPLabel;
            this.HP = 1000;
        }
        public int x { get; set; } 
        public int y { get; set; }

        public int originalX { get; set; }
        public int originalY { get; set; }
        public int width { get; set; }

        public int height { get; set; }

        public int HP { get; set; }

        public PictureBox pictureBox { get; set; }

        public Label HPLabel { get; set; }
        public void moveTo(LoEC loEC)
        {
            pictureBox.BringToFront();
            int xSpeed = 10;
            while (x+width<=loEC.x)
            {
                pictureBox.Left= x +xSpeed;
                x = x +xSpeed;
                Thread.Sleep(10);
            }
          
            while (x>=originalX)
            {
                pictureBox.Left = x - xSpeed;
                x = x - xSpeed;
                Thread.Sleep(10);
            }
            x = originalX;
            pictureBox.Left = originalX;
            int random = new Random().Next(140, 160);
            loEC.HP -= random;
            loEC.HPLabel.Width -= (int)(random * 1.0 / 1000 * 256);
            loEC.HPLabel.Left += (int)(random * 1.0 / 1000 * 256);

        }
    }
} 
