﻿using Click_Game.Panel_uri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            this.Controls.Add(new pnlStart(this));

        }
    }
}
