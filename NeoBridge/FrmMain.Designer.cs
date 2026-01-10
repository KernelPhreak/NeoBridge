namespace NeoBridge
{
    partial class FrmMain
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
            statusStrip1 = new StatusStrip();
            LblStatus = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            BtnConnect = new Button();
            CmbFolder = new ComboBox();
            CmbDrive = new ComboBox();
            CmbDevice = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnBrowse = new Button();
            TxtSaveToPath = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            LstLog = new ListBox();
            button1 = new Button();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblStatus });
            statusStrip1.Location = new Point(0, 460);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(701, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            LblStatus.Name = "LblStatus";
            LblStatus.Padding = new Padding(0, 0, 10, 0);
            LblStatus.Size = new Size(98, 17);
            LblStatus.Text = "Not Connected";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(BtnConnect);
            groupBox1.Controls.Add(CmbFolder);
            groupBox1.Controls.Add(CmbDrive);
            groupBox1.Controls.Add(CmbDevice);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 82);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Camera Connection";
            // 
            // BtnConnect
            // 
            BtnConnect.Location = new Point(587, 27);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(75, 23);
            BtnConnect.TabIndex = 4;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += BtnConnect_Click;
            // 
            // CmbFolder
            // 
            CmbFolder.FormattingEnabled = true;
            CmbFolder.Location = new Point(417, 27);
            CmbFolder.Name = "CmbFolder";
            CmbFolder.Size = new Size(164, 23);
            CmbFolder.TabIndex = 3;
            // 
            // CmbDrive
            // 
            CmbDrive.FormattingEnabled = true;
            CmbDrive.Location = new Point(247, 27);
            CmbDrive.Name = "CmbDrive";
            CmbDrive.Size = new Size(164, 23);
            CmbDrive.TabIndex = 2;
            // 
            // CmbDevice
            // 
            CmbDevice.FormattingEnabled = true;
            CmbDevice.Location = new Point(72, 27);
            CmbDevice.Name = "CmbDevice";
            CmbDevice.Size = new Size(169, 23);
            CmbDevice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Device:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnBrowse);
            groupBox2.Controls.Add(TxtSaveToPath);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Auto Transfer Settings";
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(417, 29);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(75, 23);
            BtnBrowse.TabIndex = 5;
            BtnBrowse.Text = "Browse";
            BtnBrowse.UseVisualStyleBackColor = true;
            // 
            // TxtSaveToPath
            // 
            TxtSaveToPath.Location = new Point(77, 29);
            TxtSaveToPath.Name = "TxtSaveToPath";
            TxtSaveToPath.Size = new Size(334, 23);
            TxtSaveToPath.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 32);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Save To:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LstLog);
            groupBox3.Location = new Point(12, 271);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(677, 184);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Transfer Log";
            // 
            // LstLog
            // 
            LstLog.FormattingEnabled = true;
            LstLog.Location = new Point(21, 22);
            LstLog.Name = "LstLog";
            LstLog.Size = new Size(641, 154);
            LstLog.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(587, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 482);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "NeoBridge";
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblStatus;
        private GroupBox groupBox1;
        private Button BtnConnect;
        private ComboBox CmbFolder;
        private ComboBox CmbDrive;
        private ComboBox CmbDevice;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtSaveToPath;
        private Label label2;
        private Button BtnBrowse;
        private GroupBox groupBox3;
        private ListBox LstLog;
        private Button button1;
    }
}
