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
        Rectangle bounds;
        public Form2()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
            bounds = Bounds;
            form1 = new Form1();
            scrshot = new Screenshot();
            InitializeComponent();
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            if (form1.isNewBounds)
                bounds = scrshot.GetNewBounds(bounds);
            Hide();
            Thread.Sleep(500);
            form1.screen = scrshot.MakeScreenshot(bounds);
            Show();
            form1.screen.Save(form1.path + form1.fileFormat, form1.format);//add file's name
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }
    }
}
