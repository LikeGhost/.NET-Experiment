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
            holySpirit = new HolySpirit(HolySpiritBox,HPOne);
            loEC = new LoEC(LoECBox,HPTwo);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            holySpirit.MoveTo(loEC);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            loEC.MoveTo(holySpirit);
        }

       
    }
}
