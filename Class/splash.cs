using System;
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
    public partial class splash : Form
    {
        public splash(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Owner = parentForm;
        }
    }
}
