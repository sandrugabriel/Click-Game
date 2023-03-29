using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Click_Game.Panel_uri
{
    internal class pnlGame : Panel
    {

        Form1 form;

        Timer timer;

        Label lblScore;

        ProgressBar barHealth;

        private int pozX;
        private int pozY;
        private int score;

        Random random;

        List<PictureBox> pictures;

       

        public pnlGame(Form1 form1)
        {
            form = form1;
            score = 0;

            pictures = new List<PictureBox>();

            random = new Random();

            this.Name = "pnlGame";
            this.form.Size = new System.Drawing.Size(825, 571);
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(form.Size.Width, form.Size.Height);
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Click += new EventHandler(pnlGame_Click);

            Font font = new Font("Microsoft YaHei UI Light", 18);

            //Timer 
            timer = new Timer();

            timer.Interval = 300;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            //Score
            lblScore = new Label();
            this.Controls.Add(lblScore);

            lblScore.Location = new System.Drawing.Point(10, 5);
            lblScore.AutoSize = true;
            lblScore.Font = font;
            lblScore.Text = "Score: " + score.ToString();

            //Bar
            barHealth = new ProgressBar();
            this.Controls.Add(barHealth);
            this.barHealth.Width = 300;
            this.barHealth.Height = 40;
            this.barHealth.BackColor = System.Drawing.Color.Red;
            this.barHealth.ForeColor = System.Drawing.Color.Red;
            this.barHealth.Location = new System.Drawing.Point(455,5);
            this.barHealth.Maximum = 350;

        }

        private void pnlGame_Click(object sender, EventArgs e)
        {
               PictureBox pct = sender as PictureBox;
            if(pct  != null)
            {
                this.Controls.Remove(pct);
                score++;
            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int semn = 0;
            lblScore.Text = "Score: " + score.ToString();

            pozX = random.Next(15, 700);
            pozY = random.Next(100, 350);


            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new System.Drawing.Point(pozX, pozY);
            pictureBox.Size = new Size(10, 10);
            pictureBox.Name = "pictureBox";
            pictureBox.BackColor = System.Drawing.Color.FromArgb((byte)random.Next(1, 255), (byte)random.Next(1, 255), (byte)random.Next(1, 255));
            this.Controls.Add(pictureBox);

            pictureBox.Click += new EventHandler(pnlGame_Click);
            if (barHealth.Value >= 350)
            {
                timer.Enabled = false;
                timer.Stop();
               
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pct)
                {
                    pct.Height += 5;
                    pct.Width += 5;


                  

                    if (pct.Width > 90)
                    {
                        this.Controls.Remove(pct);
                        barHealth.Value += 14;


                    }
                    if(barHealth.Value >= 350)
                    {
                        timer.Enabled = false;
                        timer.Stop();

                        foreach(Control control1 in this.Controls)
                        {
                            if(control1 is PictureBox pct1)
                            this.Controls.Remove(pct1);
                        }
                        semn = 1;
                      
                    }


                }


            }

            if (semn == 1)
            {

                foreach (Control control1 in this.Controls)
                {
                    if (control1 is PictureBox pct1)
                        this.Controls.Remove(pct1);
                }
                MessageBox.Show("You lose! \n Score: " + score.ToString(), "Lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.form.removepnl("pnlGame");
                this.form.Controls.Add(new pnlStart(form));


            }

        }

    }
}
