
namespace TestingAWS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btnSendSNS = new Button();
            tabPage2 = new TabPage();
            btnSendSQS = new Button();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(952, 458);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnSendSNS);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(944, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SNS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 163);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnSendSNS
            // 
            btnSendSNS.Location = new Point(93, 201);
            btnSendSNS.Name = "btnSendSNS";
            btnSendSNS.Size = new Size(79, 30);
            btnSendSNS.TabIndex = 0;
            btnSendSNS.Text = "Send SNS";
            btnSendSNS.UseVisualStyleBackColor = true;
            btnSendSNS.Click += btnSendSNS_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSendSQS);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(944, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SQS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSendSQS
            // 
            btnSendSQS.Location = new Point(87, 204);
            btnSendSQS.Name = "btnSendSQS";
            btnSendSQS.Size = new Size(78, 29);
            btnSendSQS.TabIndex = 1;
            btnSendSQS.Text = "Send SQS";
            btnSendSQS.UseVisualStyleBackColor = true;
            btnSendSQS.Click += this.btnSendSQS_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 181);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 505);
            Controls.Add(tabControl1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Testing AWS Services";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

       

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSendSNS;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSendSQS;
    }
}
