﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scomp
{
    public partial class progress : Form
    {
        public progress(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Owner = parentForm;
        }

        public void UpdateProgress(int value)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => progressBar.Value = value));
            }
            else
            {
                progressBar.Value = value;
            }
        }

        public void SetProgressMax(int max)
        {
            progressBar.Maximum = max;
        }
    }
}
