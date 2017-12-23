namespace Client
{
    partial class Client
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverip = new System.Windows.Forms.TextBox();
            this.duankou = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.sendtext = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Sendall = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号";
            // 
            // serverip
            // 
            this.serverip.Location = new System.Drawing.Point(100, 35);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(186, 25);
            this.serverip.TabIndex = 2;
            this.serverip.Text = "192.168.1.106";
            // 
            // duankou
            // 
            this.duankou.Location = new System.Drawing.Point(353, 35);
            this.duankou.Name = "duankou";
            this.duankou.Size = new System.Drawing.Size(186, 25);
            this.duankou.TabIndex = 3;
            this.duankou.Text = "50000";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(100, 90);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(706, 256);
            this.textBox.TabIndex = 4;
            // 
            // sendtext
            // 
            this.sendtext.Location = new System.Drawing.Point(100, 372);
            this.sendtext.Multiline = true;
            this.sendtext.Name = "sendtext";
            this.sendtext.Size = new System.Drawing.Size(706, 45);
            this.sendtext.TabIndex = 5;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(562, 443);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(79, 35);
            this.Send.TabIndex = 6;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // Sendall
            // 
            this.Sendall.Location = new System.Drawing.Point(727, 443);
            this.Sendall.Name = "Sendall";
            this.Sendall.Size = new System.Drawing.Size(79, 35);
            this.Sendall.TabIndex = 7;
            this.Sendall.Text = "群发";
            this.Sendall.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(662, 35);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(144, 23);
            this.comboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "选择发送目标";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(100, 443);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(104, 29);
            this.connect.TabIndex = 10;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 490);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Sendall);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.sendtext);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.duankou);
            this.Controls.Add(this.serverip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.TextBox duankou;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox sendtext;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Sendall;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
    }
}

