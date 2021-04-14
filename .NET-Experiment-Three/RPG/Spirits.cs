using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPG
{
    class Spirits
    {

        public Spirits(PictureBox PictureBox, Label HeroLabel)
        {
            this.X = PictureBox.Location.X;
            this.Y = PictureBox.Location.Y;
            this.OriginalX = PictureBox.Location.X;
            this.OriginalY = PictureBox.Location.Y;
            this.Width = PictureBox.Width;
            this.Height = PictureBox.Height;
            this.PictureBox = PictureBox;
            this.HeroLabel = HeroLabel;
            this.HP = 1000;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public int OriginalX { get; set; }
        public int OriginalY { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }

        public int HP { get; set; }

        public PictureBox PictureBox { get; set; }

        public Label HeroLabel { get; set; }
        public void MoveTo() { }
    }
}
