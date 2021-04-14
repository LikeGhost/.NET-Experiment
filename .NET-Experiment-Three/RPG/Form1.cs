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
            holySpirit = new HolySpirit(HolySpiritBox,HPLeft);
            loEC = new LoEC(LoECBox,HPRight);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            holySpirit.moveTo(loEC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loEC.moveTo(holySpirit);
        }

       
    }
}
