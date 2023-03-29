using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Game.Panel_uri
{
    internal class pnlStart : Panel
    {
        Form1 form;

        Button btnStart;
        Button btnExit;

        PictureBox pctBox;

        public pnlStart(Form1 form1)
        {

            form = form1;
            this.Name = "pnlStart";
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(form.Size.Width,form.Size.Height);

            Font font = new Font("Microsoft YaHei UI Light", 22);

            //Button Start
            btnStart = new Button();
            this.Controls.Add(btnStart);

            this.btnStart.Location = new System.Drawing.Point(110,180);
            this.btnStart.Size = new System.Drawing.Size(120,50);
            this.btnStart.Font = font;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(btnStart_Click);
            this.btnStart.Anchor = AnchorStyles.Top;

            //Button Exit
            btnExit = new Button();
            this.Controls.Add(btnExit);

            this.btnExit.Location = new System.Drawing.Point(110, 250);
            this.btnExit.Size = new System.Drawing.Size(120, 50);
            this.btnExit.Font = font;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new EventHandler(btnExit_Click);
            this.btnExit.Anchor = AnchorStyles.Top;

            //Picture
            pctBox = new PictureBox();
            this.Controls.Add(pctBox);

            pctBox.Location = new System.Drawing.Point(110,20);
            pctBox.Size = new System.Drawing.Size(125,125);
            pctBox.Image = Image.FromFile(Application.StartupPath + @"/images/click.png");
            pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctBox.Anchor = AnchorStyles.Top;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlStart");
            this.form.Controls.Add(new pnlGame(form));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.form.Close();


        }

    }
}
