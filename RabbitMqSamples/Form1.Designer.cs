namespace RabbitMqSamples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnectRabbitMQ = new Button();
            btnCreateExchange = new Button();
            btnCreatteQueues = new Button();
            btnBindQueues = new Button();
            txtMobileMessage = new TextBox();
            btnPublishMobileMessage = new Button();
            lblMobile = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtWebMessage = new TextBox();
            lblWebMessages = new Label();
            btnPublishWebMessage = new Button();
            lblMobileMessages = new Label();
            lsbMobile = new ListBox();
            lsbWebMessages = new ListBox();
            lblWebsMessages = new Label();
            btnsubMobile = new Button();
            btnsubWeb = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnectRabbitMQ
            // 
            btnConnectRabbitMQ.Location = new Point(38, 26);
            btnConnectRabbitMQ.Name = "btnConnectRabbitMQ";
            btnConnectRabbitMQ.Size = new Size(184, 49);
            btnConnectRabbitMQ.TabIndex = 0;
            btnConnectRabbitMQ.Text = "Connect RabbitMQ";
            btnConnectRabbitMQ.UseVisualStyleBackColor = true;
            btnConnectRabbitMQ.Click += btnConnectRabbitMQ_Click;
            // 
            // btnCreateExchange
            // 
            btnCreateExchange.Location = new Point(38, 105);
            btnCreateExchange.Name = "btnCreateExchange";
            btnCreateExchange.Size = new Size(184, 51);
            btnCreateExchange.TabIndex = 1;
            btnCreateExchange.Text = "Create Exchange";
            btnCreateExchange.UseVisualStyleBackColor = true;
            btnCreateExchange.Click += btnCreateExchange_Click;
            // 
            // btnCreatteQueues
            // 
            btnCreatteQueues.Location = new Point(38, 185);
            btnCreatteQueues.Name = "btnCreatteQueues";
            btnCreatteQueues.Size = new Size(184, 54);
            btnCreatteQueues.TabIndex = 2;
            btnCreatteQueues.Text = "Creatte Queues";
            btnCreatteQueues.UseVisualStyleBackColor = true;
            btnCreatteQueues.Click += btnCreatteQueues_Click;
            // 
            // btnBindQueues
            // 
            btnBindQueues.Location = new Point(38, 279);
            btnBindQueues.Name = "btnBindQueues";
            btnBindQueues.Size = new Size(184, 53);
            btnBindQueues.TabIndex = 3;
            btnBindQueues.Text = "Bind Queues";
            btnBindQueues.UseVisualStyleBackColor = true;
            btnBindQueues.Click += btnBindQueues_Click;
            // 
            // txtMobileMessage
            // 
            txtMobileMessage.Location = new Point(22, 39);
            txtMobileMessage.Multiline = true;
            txtMobileMessage.Name = "txtMobileMessage";
            txtMobileMessage.Size = new Size(351, 65);
            txtMobileMessage.TabIndex = 4;
            // 
            // btnPublishMobileMessage
            // 
            btnPublishMobileMessage.Location = new Point(279, 110);
            btnPublishMobileMessage.Name = "btnPublishMobileMessage";
            btnPublishMobileMessage.Size = new Size(94, 29);
            btnPublishMobileMessage.TabIndex = 5;
            btnPublishMobileMessage.Text = "Publish";
            btnPublishMobileMessage.UseVisualStyleBackColor = true;
            btnPublishMobileMessage.Click += btnPublishMobileMessage_Click;
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(22, 9);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(124, 20);
            lblMobile.TabIndex = 6;
            lblMobile.Text = "Mobile Messages";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtMobileMessage);
            panel1.Controls.Add(lblMobile);
            panel1.Controls.Add(btnPublishMobileMessage);
            panel1.Location = new Point(261, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 160);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtWebMessage);
            panel2.Controls.Add(lblWebMessages);
            panel2.Controls.Add(btnPublishWebMessage);
            panel2.Location = new Point(261, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 154);
            panel2.TabIndex = 8;
            // 
            // txtWebMessage
            // 
            txtWebMessage.Location = new Point(22, 37);
            txtWebMessage.Multiline = true;
            txtWebMessage.Name = "txtWebMessage";
            txtWebMessage.Size = new Size(335, 67);
            txtWebMessage.TabIndex = 4;
            // 
            // lblWebMessages
            // 
            lblWebMessages.AutoSize = true;
            lblWebMessages.Location = new Point(22, 9);
            lblWebMessages.Name = "lblWebMessages";
            lblWebMessages.Size = new Size(107, 20);
            lblWebMessages.TabIndex = 6;
            lblWebMessages.Text = "Web Messages";
            // 
            // btnPublishWebMessage
            // 
            btnPublishWebMessage.Location = new Point(263, 110);
            btnPublishWebMessage.Name = "btnPublishWebMessage";
            btnPublishWebMessage.Size = new Size(94, 29);
            btnPublishWebMessage.TabIndex = 5;
            btnPublishWebMessage.Text = "Publish";
            btnPublishWebMessage.UseVisualStyleBackColor = true;
            btnPublishWebMessage.Click += btnPublishWebMessage_Click;
            // 
            // lblMobileMessages
            // 
            lblMobileMessages.AutoSize = true;
            lblMobileMessages.Location = new Point(701, 36);
            lblMobileMessages.Name = "lblMobileMessages";
            lblMobileMessages.Size = new Size(124, 20);
            lblMobileMessages.TabIndex = 9;
            lblMobileMessages.Text = "Mobile Messages";
            // 
            // lsbMobile
            // 
            lsbMobile.FormattingEnabled = true;
            lsbMobile.ItemHeight = 20;
            lsbMobile.Location = new Point(705, 62);
            lsbMobile.Name = "lsbMobile";
            lsbMobile.ScrollAlwaysVisible = true;
            lsbMobile.Size = new Size(411, 124);
            lsbMobile.TabIndex = 10;
            // 
            // lsbWebMessages
            // 
            lsbWebMessages.FormattingEnabled = true;
            lsbWebMessages.ItemHeight = 20;
            lsbWebMessages.Location = new Point(705, 222);
            lsbWebMessages.Name = "lsbWebMessages";
            lsbWebMessages.ScrollAlwaysVisible = true;
            lsbWebMessages.Size = new Size(411, 124);
            lsbWebMessages.TabIndex = 12;
            // 
            // lblWebsMessages
            // 
            lblWebsMessages.AutoSize = true;
            lblWebsMessages.Location = new Point(701, 196);
            lblWebsMessages.Name = "lblWebsMessages";
            lblWebsMessages.Size = new Size(107, 20);
            lblWebsMessages.TabIndex = 11;
            lblWebsMessages.Text = "Web Messages";
            // 
            // btnsubMobile
            // 
            btnsubMobile.Location = new Point(751, 374);
            btnsubMobile.Name = "btnsubMobile";
            btnsubMobile.Size = new Size(145, 29);
            btnsubMobile.TabIndex = 13;
            btnsubMobile.Text = "Subscribe Mobile";
            btnsubMobile.UseVisualStyleBackColor = true;
            btnsubMobile.Click += btnsubMobile_Click;
            // 
            // btnsubWeb
            // 
            btnsubWeb.Location = new Point(924, 374);
            btnsubWeb.Name = "btnsubWeb";
            btnsubWeb.Size = new Size(145, 29);
            btnsubWeb.TabIndex = 14;
            btnsubWeb.Text = "Subscribe Web";
            btnsubWeb.UseVisualStyleBackColor = true;
            btnsubWeb.Click += btnsubWeb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 447);
            Controls.Add(btnsubWeb);
            Controls.Add(btnsubMobile);
            Controls.Add(lsbWebMessages);
            Controls.Add(lblWebsMessages);
            Controls.Add(lsbMobile);
            Controls.Add(lblMobileMessages);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBindQueues);
            Controls.Add(btnCreatteQueues);
            Controls.Add(btnCreateExchange);
            Controls.Add(btnConnectRabbitMQ);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnectRabbitMQ;
        private Button btnCreateExchange;
        private Button btnCreatteQueues;
        private Button btnBindQueues;
        private TextBox txtMobileMessage;
        private Button btnPublishMobileMessage;
        private Label lblMobile;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtWebMessage;
        private Label lblWebMessages;
        private Button btnPublishWebMessage;
        private Label lblMobileMessages;
        private ListBox lsbMobile;
        private ListBox lsbWebMessages;
        private Label lblWebsMessages;
        private Button btnsubMobile;
        private Button btnsubWeb;
    }
}