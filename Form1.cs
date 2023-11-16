using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Congratulation_form
{
    public partial class Form1 : Form
            {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse
           );
       

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung congratulation
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
          button1.Height, 12, 12));

        }
        private void Welcome_Click(object sender, EventArgs e)
        {
            // Header congratulation
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button get started
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // khung trắng 
        }
    }
}
