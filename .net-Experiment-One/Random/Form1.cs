using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNum
{
    public partial class RandomForm : Form
    {
        public RandomForm()
        {
            InitializeComponent();
        }


        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (textBoxM.Text != "" && textBoxN.Text != "")
            {
                int n = int.Parse(textBoxN.Text), m = int.Parse(textBoxM.Text);
                int[] arr=new int[n+1];

                for (int i =0; i<arr.Length; i++)
                {
                    arr[i] = i;
                }
                for(int i=1;i<=m ; i++) 
                {
                    Random r = new();
                    int ranKey = r.Next(i, n);
                    int temp = arr[ranKey];
                    arr[ranKey] = arr[i];
                    arr[i] = temp;
                }
                for(int i=1;i<=m ;i++ )
                {
                    textBoxOut.Text = textBoxOut.Text+ arr[i] + " ";
                }

            }
        }
    }
}
