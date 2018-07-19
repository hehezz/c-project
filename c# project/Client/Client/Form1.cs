using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

 
        void ShowMsg(string str)
        {
            textBox.AppendText(str + "\r\n");
        }

        private void connect_Click(object sender, EventArgs e)
        {
            //创建负责通信的Socket
            Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(serverip.Text);
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(duankou.Text));
            //获得要连接的远程服务器应用程序的IP地址和端口号
            socketSend.Connect(point);
            ShowMsg("连接成功");
        }

        public void Test()
        {
            Console.WriteLine("xasdfq");
        }
    }
}
