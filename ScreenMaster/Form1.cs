using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenMaster
{
    public partial class Form1 : Form
    {
        public Bitmap screen;
        public Rectangle bounds;
        public bool isNewBounds = false;
        private bool isSendServer = false;
        public string path;
        public ImageFormat format;
        public string fileFormat;
        Screenshot scrshot;
        NetworkClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                //dialog.ShowNewFolderButton = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath + "\\picture";
                    textBoxPath.Text = path;
                }
            }
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            if (comboBoxCase.SelectedIndex == 0)
            {
                //MakeImage(this, bounds.Location, bounds);
                if (isNewBounds)
                    bounds = scrshot.GetNewBounds(bounds);
                Hide();
                Thread.Sleep(500);
                screen = scrshot.MakeScreenshot(bounds, bounds.Location);
                Show();
                if (isSendServer)
                    client.SendImage(screen);
                screen.Save(path + fileFormat, format);
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }


            //fileStream = new FileStream(path, FileMode.Create);
            ////using (fileStream = File.Create(path, (int)stream.Length))
            ////{
            //byte[] data = new byte[stream.Length];
            //stream.Read(data, 0, data.Length);
            //fileStream.Write(data, 0, data.Length);
            //fileStream.Close();
            ////stream.Close();
            ////}
        }

        //public void MakeImage(Form form, Point location, Rectangle bounds)
        //{
        //    if (isNewBounds)
        //        bounds = scrshot.GetNewBounds(bounds);
        //    form.Hide();
        //    Thread.Sleep(500);
        //    screen = scrshot.MakeScreenshot(bounds, location);
        //    form.Show();
        //    screen.Save(path + fileFormat, format);
        //}

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                switch(radioButton.Text)
                {
                    case "PNG":
                        format = ImageFormat.Png;
                        fileFormat = ".png";
                        break;
                    case "JPEG":
                        format = ImageFormat.Jpeg;
                        fileFormat = ".jpeg";
                        break;
                    case "BMP":
                        format = ImageFormat.Bmp;
                        fileFormat = ".bmp";
                        break;
                    case "GIF":
                        format = ImageFormat.Png;
                        fileFormat = ".gif";
                        break;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isNewBounds = checkBox1.Checked;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            scrshot = new Screenshot();
            client = new NetworkClient();
            radioButton1.Checked = true;
            checkBox1.Text = "Компенсация масштабирования экрана" + "\n" + "(экспериментальная функция)";
            path = "C:\\Users\\Cyfralus\\Documents\\Visual Studio 2015\\Projects\\ScreenMaster\\ScreenMaster\\bin\\Debug\\picture";
            textBoxPath.Text = path;
            bounds = Screen.PrimaryScreen.Bounds;
            comboBoxCase.SelectedIndex = 0;
        }

        private void checkBoxSendtoServer_CheckedChanged(object sender, EventArgs e)
        {
            isSendServer = checkBoxSendtoServer.Checked;
        }
    }
}
