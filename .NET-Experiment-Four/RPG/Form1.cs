using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HS = new HolySpirit(HSBox, HPOne);
            LoEC = new LordofEssentialChaos(LoECBox, HPTwo);
            STR = new SaintTingRey(STRBox, HPThree);
            DTI = new DarkThunderlshulandi(DTIBox, HPFour);

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Attacker = HS;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Attacker = LoEC;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Attacker = DTI;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Attacker = STR;
        }

        private void LoECBox_Click(object sender, EventArgs e)
        {
            
            Attacker.Attack(LoEC);
        }

        private void HSBox_Click(object sender, EventArgs e)
        {
            Attacker.Attack(HS);
        }

        

        private void STRBox_Click(object sender, EventArgs e)
        {
            Attacker.Attack(STR);
        }

        private void DTIBox_Click(object sender, EventArgs e)
        {
            Attacker.Attack(DTI);
        }

    }
}
