namespace Server
{
    partial class Server
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
            this.duankou = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntStart = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // duankou
            // 
            this.duankou.Location = new System.Drawing.Point(350, 69);
            this.duankou.Name = "duankou";
            this.duankou.Size = new System.Drawing.Size(86, 25);
            this.duankou.TabIndex = 7;
            this.duankou.Text = "50000";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(97, 69);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(186, 25);
            this.ip.TabIndex = 6;
            this.ip.Text = "192.168.1.106";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ip地址";
            // 
            // bntStart
            // 
            this.bntStart.Location = new System.Drawing.Point(469, 69);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(113, 35);
            this.bntStart.TabIndex = 8;
            this.bntStart.Text = "开始监听";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(97, 121);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(485, 255);
            this.textBox.TabIndex = 9;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 388);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bntStart);
            this.Controls.Add(this.duankou);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox duankou;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.TextBox textBox;
    }
}

