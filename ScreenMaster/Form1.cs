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
        private bool onlyServer = false;
        public string path;
        string date;
        public ImageFormat format;
        public string fileFormat;
        Screenshot scrshot;
        NetworkClient client;
        Form2 form2;

        public Form1()
        {
            scrshot = new Screenshot();
            client = new NetworkClient();
            InitializeComponent();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath + "\\";
                    textBoxPath.Text = path;
                }
            }
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            if (comboBoxCase.SelectedIndex == 0)
            {
                MakeImage(this, bounds.Location, bounds);
            }
            else
            {
                form2 = new Form2();
                form2.Owner = this;
                form2.Show();
                this.Hide();
            }
        }

        public void MakeImage(Form form, Point location, Rectangle bounds)
        {
            date = GetCurrentDate();

            if (isNewBounds)
            {
                bounds = scrshot.GetNewBounds(bounds);
                location = scrshot.GetNewLocation(location);
            }
            form.Hide();
            Thread.Sleep(500);
            screen = scrshot.MakeScreenshot(bounds, location);
            form.Show();
            if (isSendServer)
            {
                client.SendImage(screen, date, fileFormat);
                textBoxLink.Text = client.GetLink();
            }
            if(!onlyServer)
            try
            {
                screen.Save(path + date + fileFormat, format);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте путь! Возможно, его не существует");
            }
        }

        private string GetCurrentDate()
        {
            string currentDate;
            DateTime curDate = DateTime.Now;
            string currentTime = "";
            string fullDate = curDate.ToString();
            string[] date = fullDate.Split(' ');
            string[] time = date[1].Split(':');
            foreach (string unit in time)
            {
                currentTime += "_" + unit;
            }
            currentDate = date[0] + currentTime;
            return currentDate;
        }

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
            radioButton1.Checked = true;
            checkBox1.Text = "Компенсация масштабирования экрана" + "\n" + "(экспериментальная функция)";
            path = Application.StartupPath + "\\";
            textBoxPath.Text = path;
            bounds = Screen.PrimaryScreen.Bounds;
            comboBoxCase.SelectedIndex = 0;
        }

        public void FormClose()
        {
            form2.Close();
        }

        private void checkBoxSendtoServer_CheckedChanged(object sender, EventArgs e)
        {
            if (onlyServer && !checkBoxSendtoServer.Checked)
                checkBoxSendtoServer.Checked = true;
            isSendServer = checkBoxSendtoServer.Checked;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void buttonCopyLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxLink.Text);
        }

        private void checkBoxOnlyServer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnlyServer.Checked)
                checkBoxSendtoServer.Checked = true;
            onlyServer = checkBoxOnlyServer.Checked;
        }
    }
}
