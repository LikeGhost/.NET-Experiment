using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RPG
{
    class LoEC
    {
        public LoEC(PictureBox pictureBox,Label HPLabel)
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
        public void moveTo(HolySpirit holySpirit)
        {
            pictureBox.BringToFront();
            int xSpeed = 10;

            while (x >= holySpirit.x + holySpirit.width)
            {
                pictureBox.Left = x - xSpeed;
                x = x - xSpeed;
                Thread.Sleep(10);
            }

            while (x <=originalX)
            {
                pictureBox.Left = x + xSpeed;
                x = x + xSpeed;
                Thread.Sleep(10);
            }
            x = originalX;
            pictureBox.Left = originalX;
            int random = new Random().Next(140, 160);
            holySpirit.HP -= random;
            holySpirit.HPLabel.Width -= (int)(random * 1.0 / 1000 * 256);
        }
    }
}
