using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenMaster
{
    public partial class Form2 : Form
    {
        Form1 form1;
        Screenshot scrshot;
        public Form2()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
            scrshot = new Screenshot();
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SIZEBOX = 0x40000;

                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;

                return cp;
            }
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            //Form1 form1 = this.Owner as Form1;
            //bounds = Bounds;
            form1.MakeImage(this, Location, Bounds);
            //if (form1.isNewBounds)
            //    bounds = scrshot.GetNewBounds(bounds);
            //Hide();
            //Thread.Sleep(500);
            //form1.screen = scrshot.MakeScreenshot(bounds, Location);
            //Show();
            //form1.screen.Save(form1.path + form1.fileFormat, form1.format);//add file's name
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            form1 = this.Owner as Form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.FormClose();
            if (form1 != null)
                form1.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Size = new Size(this.PointToClient(MousePosition).X, this.PointToClient(MousePosition).Y);
            }
        }
    }
}
