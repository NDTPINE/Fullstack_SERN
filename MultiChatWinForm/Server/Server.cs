using System;
using System.CodeDom;
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

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientSocket;

        /// <summary>
        /// ket noi server
        /// </summary>
        void Connect()
        {
            clientSocket = new List<Socket>();
            //IP dia chi cua server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientSocket.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
                
            });

            Listen.IsBackground = true;
            Listen.Start();
        }
        /// <summary>
        /// dong connect
        /// </summary>
        void Close()
        {
            server.Close();
        }
        /// <summary>
        /// gui tin
        /// </summary>
        void Send(Socket client)
        {
            if (client != null && txbInputServer.Text != string.Empty)
                client.Send(Serialize(txbInputServer.Text));
        }
        /// <summary>
        /// nhan tin thong qua byte
        /// </summary>
        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    foreach (Socket item in clientSocket)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize(message));
                    }
                    AddMessage(message);
                }
            }
            catch
            {
                clientSocket.Remove(client);
                client.Close();
            }
        }

        void AddMessage(string s)
        {
            lvContentServer.Items.Add(new ListViewItem() { Text = s });
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

        private void btnSendServer_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientSocket)
            {
                Send(item);
            }
            AddMessage(txbInputServer.Text);
            txbInputServer.Clear();
        }
        /// <summary>
        /// dong ket noi khi tat form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}

