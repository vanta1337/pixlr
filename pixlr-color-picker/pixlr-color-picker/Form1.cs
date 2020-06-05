using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApi.User32;

namespace pixlr_color_picker
{
    public partial class Form1 : BetterForm_v2.BetterForm
    {
        Timer timer = new Timer();
        Bitmap bmp;
        Graphics gfx;
        public static string version = "0.0.1";

        public Form1()
        {
            
            InitializeComponent();
            string version = "0.0.1";
            this.DoubleBuffered = true;
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            gfx = Graphics.FromImage(bmp);

            

            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;

        }

        

    private void Timer_Tick(object sender, EventArgs e)
        {
            

            if (User32Methods.GetAsyncKeyState(VirtualKey.MENU).IsPressed)
            {
                gfx.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.PrimaryScreen.Bounds.Size);
                darkModePanel1.BackColor = bmp.GetPixel(Cursor.Position.X, Cursor.Position.Y);
                darkModePanel1.Invalidate();
                label3.Text = $"x:{Cursor.Position.X} y:{Cursor.Position.Y}";
                label2.Text = $"rgb: ({darkModePanel1.BackColor.R}, {darkModePanel1.BackColor.G}, {darkModePanel1.BackColor.B})";
                label1.Text = "hex: " + $"#{darkModePanel1.BackColor.R:x}{darkModePanel1.BackColor.G:x}{darkModePanel1.BackColor.B:x}";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void darkModeButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void darkModeButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"#{darkModePanel1.BackColor.R:x}{darkModePanel1.BackColor.G:x}{darkModePanel1.BackColor.B:x}");
        }

        private void darkModeButton1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText($"{darkModePanel1.BackColor.R}, {darkModePanel1.BackColor.G}, {darkModePanel1.BackColor.B}");
        }

        private void darkModeButton3_Click(object sender, EventArgs e)
        {
            new info().Show();
        }
    }
}
