using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenMaster
{
    class NetworkClient
    {
        private TcpClient client;
        private NetworkStream mainStream;
        private BinaryFormatter binFormater;
        private string link;

        public NetworkClient()
        {
            binFormater = new BinaryFormatter();
        }

        public string GetLink()
        {
            return link;
        }

        public void SendImage(Bitmap image, string name, string format)
        {
            Connect();

            if (client.Connected)
            {
                SendImage(image);
                SendName(name);
                SendFormat(format);
                //mainStream = client.GetStream();
                //binFormater.Serialize(mainStream, image);
                TakeLink();
            }
            client.Close();
        }

        private void SendImage(Bitmap picture)
        {
            mainStream = client.GetStream();
            binFormater.Serialize(mainStream, picture);
        }

        private void SendFormat(string format)
        {
            if (client.Connected)
            {
                mainStream = client.GetStream();
                binFormater.Serialize(mainStream, format);
            }
        }

        private void SendName(string name)
        {
            if (client.Connected)
            {
                mainStream = client.GetStream();
                binFormater.Serialize(mainStream, name);
            }
        }

        private void TakeLink()
        {
            mainStream = client.GetStream();
            link = (string)binFormater.Deserialize(mainStream);
        }

        private void Connect()
        {
            client = new TcpClient();
            try
            {
                client.Connect("loopback", 8000);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удается подключиться к серверу\nПроверьте подключение");
            }
        }
    }
}
