using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pixlr_color_picker
{
    public partial class info : BetterForm_v2.BetterForm
    {
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {
            darkModeLabel5.Text = "build: " + Form1.version;
        }
    }
}
