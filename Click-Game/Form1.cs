using Click_Game.Panel_uri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MaximumSize = new System.Drawing.Size(364, 400);
            this.MinimumSize = new System.Drawing.Size(364, 400);
            this.Controls.Add(new pnlStart(this));

        }

        public void removepnl(string pnl)
        {
            Control control = null;

            foreach (Control ctl in this.Controls)
            {

                if (ctl.Name == pnl)
                {
                    control = ctl;
                }


            }


            this.Controls.Remove(control);

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
