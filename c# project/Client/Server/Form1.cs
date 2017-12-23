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

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void bntStart_Click(object sender, EventArgs e)
        {

            //当点击开始监听的时候，在服务端创建一个负责监听IP地址和端口号的Socket
            Socket SocketWatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //获取本机ip地址
            IPAddress ip = IPAddress.Any;
            //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(duankou.Text));
            //监听
            SocketWatch.Bind(point);
            ShowMsg("监听成功");
            //最多同时容纳10个客户端
            SocketWatch.Listen(10);
            //开启一个新线程，防止主线程卡死
            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(SocketWatch);

        }
        /// <summary>
        /// 等待客户端连接 并创建一个负责通信的Socket
        /// </summary>
        /// 
        Socket socketSend;

        //创建一个储存远程连接的客户端的IP地址和Socket的集合
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            //等待客户端连接
            while (true)
            {
           
                //负责跟客户端通信的Socket
                socketSend = socketWatch.Accept();
                //将远程连接的客户端的IP地址和Socket存入集合中
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                //客户端连接成功时
                ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
            }

        }
        void ShowMsg(string str)
        {
            textBox.AppendText(str + "\r\n");
        }
    }
}
