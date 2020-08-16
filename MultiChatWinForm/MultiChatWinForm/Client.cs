using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiChatWinForm
{
    public partial class frClient : Form
    {
        public frClient()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        private void btnSendClient_Click(object sender, EventArgs e)
        {
            send();
            AddMessage(txbInputClient.Text);
        }

        IPEndPoint IP;
        Socket client; 
        /// <summary>
        /// ket noi server
        /// </summary>
        void Connect()
        {
            //IP dia chi cua server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Don't Connect Server...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.Start();
        }
        /// <summary>
        /// dong connect
        /// </summary>
        void Close()
        {
            client.Close();
        }
        /// <summary>
        /// gui tin
        /// </summary>
        void send()
        {
            if (txbInputClient.Text != string.Empty)
                client.Send(Serialize(txbInputClient.Text));
        }
        /// <summary>
        /// nhan tin thong qua byte
        /// </summary>
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        void AddMessage(string s)
        {
            lvContentClient.Items.Add(new ListViewItem() { Text = s });
            txbInputClient.Clear();
        }
        /// <summary>
        /// phan manh thanh byte
        /// </summary>
        /// <param name="ojb"></param>
        /// <returns></returns>
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        /// <summary>
        /// chuyen mang byte nhan duocj thanh object
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        /// <summary>
        /// dong ket noi khi dong form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
