using System;
using System.Collections.Generic;
using System.Drawing;
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

        public NetworkClient()
        {
            binFormater = new BinaryFormatter();
        }

        public void SendImage(Bitmap image)
        {
            Connect();

            if (client.Connected)
            {
                mainStream = client.GetStream();
                binFormater.Serialize(mainStream, image);
            }
            client.Close();
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
