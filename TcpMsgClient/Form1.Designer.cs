namespace TcpMsgClient
{
    partial class FrmClient
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientSendMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnListenServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(291, 215);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 26);
            this.btnSendMsg.TabIndex = 23;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "toServer：";
            // 
            // txtClientSendMsg
            // 
            this.txtClientSendMsg.Location = new System.Drawing.Point(83, 215);
            this.txtClientSendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientSendMsg.Name = "txtClientSendMsg";
            this.txtClientSendMsg.Size = new System.Drawing.Size(194, 21);
            this.txtClientSendMsg.TabIndex = 21;
            this.txtClientSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientSendMsg_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "聊天内容:";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(83, 41);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(366, 159);
            this.txtMsg.TabIndex = 19;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(306, 15);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(66, 21);
            this.txtPort.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "本地端口:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(83, 16);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(156, 21);
            this.txtIP.TabIndex = 16;
            // 
            // btnListenServer
            // 
            this.btnListenServer.Location = new System.Drawing.Point(376, 10);
            this.btnListenServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnListenServer.Name = "btnListenServer";
            this.btnListenServer.Size = new System.Drawing.Size(73, 26);
            this.btnListenServer.TabIndex = 15;
            this.btnListenServer.Text = "连接服务端";
            this.btnListenServer.UseVisualStyleBackColor = true;
            this.btnListenServer.Click += new System.EventHandler(this.btnListenServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP地址:";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 439);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientSendMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnListenServer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmClient";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientSendMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnListenServer;
        private System.Windows.Forms.Label label1;
    }
}

