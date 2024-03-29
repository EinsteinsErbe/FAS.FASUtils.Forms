﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASUtils.Forms
{
    public partial class TextProgressBar : UserControl
    {
        public TextProgressBar()
        {
            InitializeComponent();

            Reset();
        }

        public void Reset()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Reset()));
            }
            else
            {
                progressBar1.Value = 0;
                label1.Text = "";
            }
        }

        public void SetProgress(int value, string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetProgress(value, text)));
            }
            else
            {
                progressBar1.Value = value;
                label1.Text = text;
            }
        }
    }
}
