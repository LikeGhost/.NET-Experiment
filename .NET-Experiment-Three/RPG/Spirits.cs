using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RPG
{
    class Spirits
    {

        public Spirits(PictureBox PictureBox, Label HpLabel)
        {
            this.X = PictureBox.Location.X;
            this.Y = PictureBox.Location.Y;
            this.OriginalX = PictureBox.Location.X;
            this.OriginalY = PictureBox.Location.Y;
            this.Width = PictureBox.Width;
            this.Height = PictureBox.Height;
            this.PictureBox = PictureBox;
            this.HPLabel = HpLabel;
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

        public Label HPLabel { get; set; }

        public int AttackKind { get; set; }
        public void MoveTo(Spirits Other)
        {
            PictureBox.BringToFront();
            int xSpeed = (Other.X - this.X) / 50;
            int ySpeed = (Other.Y - this.Y) / 50;
            while (!Tool.IsCrash(this, Other))
            {
                PictureBox.Left = X + xSpeed;
                PictureBox.Top = Y + ySpeed;
                X += xSpeed;
                Y += ySpeed;
                Thread.Sleep(10);
            }

            while (Math.Abs(X - OriginalX) >= 10)
            {
                PictureBox.Left = X - xSpeed;
                PictureBox.Top = Y - ySpeed;
                X -= xSpeed;
                Y -= ySpeed;
                Thread.Sleep(10);
            }
            X = OriginalX;
            Y = OriginalY;
            PictureBox.Left = OriginalX;
            PictureBox.Top = OriginalY;

        }

      /*  public void Shoot(Spirits Other)
        {
           *//* Graphics g = new Graphics();*//*
        }*/
        public void Attack(Spirits Other)
        {
           /* if (AttackKind == 1)
            {
                MoveTo(Other);
            }
            else if (AttackKind == 2)
            {
                Shoot(Other);
            }*/
           MoveTo(Other);
            int random = new Random().Next(140, 160);
            Other.HP -= random;
            Other.HPLabel.Width -= (int)(random * 1.0 / 1000 * 256);
            Other.HPLabel.Left += (int)(random * 1.0 / 1000 * 256);
        }
    }
}
