namespace WindowsFormsApp2_presskey
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxOwnId = new System.Windows.Forms.TextBox();
            this.labelOwnPID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getOwnThread = new System.Windows.Forms.Button();
            this.textBoxFlyffPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFlyff2PID = new System.Windows.Forms.TextBox();
            this.StartFlyff = new System.Windows.Forms.Button();
            this.ThreadbyName = new System.Windows.Forms.Button();
            this.AppActivateButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyEventBox1 = new System.Windows.Forms.TextBox();
            this.ExeLocation = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ACTIVEBUTTON = new System.Windows.Forms.Button();
            this.buttonGetPIDs = new System.Windows.Forms.Button();
            this.TitleFilterBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKeyToSend = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOwnId
            // 
            this.textBoxOwnId.Location = new System.Drawing.Point(66, 96);
            this.textBoxOwnId.Name = "textBoxOwnId";
            this.textBoxOwnId.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnId.TabIndex = 1;
            // 
            // labelOwnPID
            // 
            this.labelOwnPID.AutoSize = true;
            this.labelOwnPID.Location = new System.Drawing.Point(13, 99);
            this.labelOwnPID.Name = "labelOwnPID";
            this.labelOwnPID.Size = new System.Drawing.Size(50, 13);
            this.labelOwnPID.TabIndex = 3;
            this.labelOwnPID.Text = "Own PID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PID 1";
            // 
            // getOwnThread
            // 
            this.getOwnThread.Location = new System.Drawing.Point(180, 95);
            this.getOwnThread.Name = "getOwnThread";
            this.getOwnThread.Size = new System.Drawing.Size(75, 22);
            this.getOwnThread.TabIndex = 4;
            this.getOwnThread.Text = "Get Thread";
            this.getOwnThread.UseVisualStyleBackColor = true;
            this.getOwnThread.Click += new System.EventHandler(this.getOwnThread_Click);
            // 
            // textBoxFlyffPID
            // 
            this.textBoxFlyffPID.Location = new System.Drawing.Point(66, 36);
            this.textBoxFlyffPID.Name = "textBoxFlyffPID";
            this.textBoxFlyffPID.Size = new System.Drawing.Size(100, 20);
            this.textBoxFlyffPID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PID 2";
            // 
            // textBoxFlyff2PID
            // 
            this.textBoxFlyff2PID.Location = new System.Drawing.Point(66, 61);
            this.textBoxFlyff2PID.Name = "textBoxFlyff2PID";
            this.textBoxFlyff2PID.Size = new System.Drawing.Size(100, 20);
            this.textBoxFlyff2PID.TabIndex = 9;
            // 
            // StartFlyff
            // 
            this.StartFlyff.Location = new System.Drawing.Point(361, 34);
            this.StartFlyff.Name = "StartFlyff";
            this.StartFlyff.Size = new System.Drawing.Size(93, 22);
            this.StartFlyff.TabIndex = 11;
            this.StartFlyff.Text = "Start Flyff";
            this.StartFlyff.UseVisualStyleBackColor = true;
            this.StartFlyff.Click += new System.EventHandler(this.StartFlyff_Click);
            // 
            // ThreadbyName
            // 
            this.ThreadbyName.Location = new System.Drawing.Point(172, 10);
            this.ThreadbyName.Name = "ThreadbyName";
            this.ThreadbyName.Size = new System.Drawing.Size(91, 22);
            this.ThreadbyName.TabIndex = 14;
            this.ThreadbyName.Text = "Get by Name";
            this.ThreadbyName.UseVisualStyleBackColor = true;
            this.ThreadbyName.Click += new System.EventHandler(this.ThreadbyName_Click);
            // 
            // AppActivateButton
            // 
            this.AppActivateButton.Location = new System.Drawing.Point(683, 139);
            this.AppActivateButton.Name = "AppActivateButton";
            this.AppActivateButton.Size = new System.Drawing.Size(105, 41);
            this.AppActivateButton.TabIndex = 17;
            this.AppActivateButton.Text = "Send to Client (HOTKEY)";
            this.AppActivateButton.UseVisualStyleBackColor = true;
            this.AppActivateButton.Click += new System.EventHandler(this.AppActivateButton_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "NONE",
            "ALT",
            "SHIFT",
            "CTRL"});
            this.comboBox3.Location = new System.Drawing.Point(19, 242);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(70, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // eventLog1
            // 
            this.eventLog1.Log = "HardwareEvents";
            this.eventLog1.Source = "eventLog1 reports:";
            this.eventLog1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(627, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 212);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buff Buttons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "MODIFIER";
            // 
            // keyEventBox1
            // 
            this.keyEventBox1.Location = new System.Drawing.Point(685, 186);
            this.keyEventBox1.Name = "keyEventBox1";
            this.keyEventBox1.ReadOnly = true;
            this.keyEventBox1.Size = new System.Drawing.Size(100, 20);
            this.keyEventBox1.TabIndex = 29;
            this.keyEventBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEventBox1_KeyDown);
            // 
            // ExeLocation
            // 
            this.ExeLocation.Location = new System.Drawing.Point(357, 10);
            this.ExeLocation.Name = "ExeLocation";
            this.ExeLocation.Size = new System.Drawing.Size(100, 20);
            this.ExeLocation.TabIndex = 30;
            this.ExeLocation.Text = "Find Sunkist.exe";
            this.ExeLocation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExeLocation_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ACTIVEBUTTON
            // 
            this.ACTIVEBUTTON.BackColor = System.Drawing.Color.Lime;
            this.ACTIVEBUTTON.Location = new System.Drawing.Point(683, 10);
            this.ACTIVEBUTTON.Name = "ACTIVEBUTTON";
            this.ACTIVEBUTTON.Size = new System.Drawing.Size(105, 41);
            this.ACTIVEBUTTON.TabIndex = 31;
            this.ACTIVEBUTTON.Text = "ACTIVATE";
            this.ACTIVEBUTTON.UseVisualStyleBackColor = false;
            this.ACTIVEBUTTON.Click += new System.EventHandler(this.ACTIVEBUTTON_Click);
            // 
            // buttonGetPIDs
            // 
            this.buttonGetPIDs.Location = new System.Drawing.Point(370, 64);
            this.buttonGetPIDs.Name = "buttonGetPIDs";
            this.buttonGetPIDs.Size = new System.Drawing.Size(75, 23);
            this.buttonGetPIDs.TabIndex = 32;
            this.buttonGetPIDs.Text = "Get PIDs";
            this.buttonGetPIDs.UseVisualStyleBackColor = true;
            this.buttonGetPIDs.Click += new System.EventHandler(this.buttonGetPIDs_Click);
            // 
            // TitleFilterBox
            // 
            this.TitleFilterBox.Location = new System.Drawing.Point(66, 10);
            this.TitleFilterBox.Name = "TitleFilterBox";
            this.TitleFilterBox.Size = new System.Drawing.Size(100, 20);
            this.TitleFilterBox.TabIndex = 33;
            this.TitleFilterBox.Text = "Flyff Universe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Title Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Select Location";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(19, 418);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 36;
            this.NameBox.Text = "Sunkist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "HOTKEY";
            // 
            // textBoxKeyToSend
            // 
            this.textBoxKeyToSend.Location = new System.Drawing.Point(95, 243);
            this.textBoxKeyToSend.Name = "textBoxKeyToSend";
            this.textBoxKeyToSend.ReadOnly = true;
            this.textBoxKeyToSend.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeyToSend.TabIndex = 38;
            this.textBoxKeyToSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyToSend_KeyDown_1);
            this.textBoxKeyToSend.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxKeyToSend_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "BUTTON";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp2_presskey.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKeyToSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TitleFilterBox);
            this.Controls.Add(this.buttonGetPIDs);
            this.Controls.Add(this.ACTIVEBUTTON);
            this.Controls.Add(this.ExeLocation);
            this.Controls.Add(this.keyEventBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.AppActivateButton);
            this.Controls.Add(this.ThreadbyName);
            this.Controls.Add(this.StartFlyff);
            this.Controls.Add(this.textBoxFlyff2PID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFlyffPID);
            this.Controls.Add(this.getOwnThread);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOwnPID);
            this.Controls.Add(this.textBoxOwnId);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOwnId;
        private System.Windows.Forms.Label labelOwnPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getOwnThread;
        private System.Windows.Forms.TextBox textBoxFlyffPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFlyff2PID;
        private System.Windows.Forms.Button StartFlyff;
        private System.Windows.Forms.Button ThreadbyName;
        private System.Windows.Forms.Button AppActivateButton;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox keyEventBox1;
        private System.Windows.Forms.TextBox ExeLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ACTIVEBUTTON;
        private System.Windows.Forms.Button buttonGetPIDs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TitleFilterBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKeyToSend;
    }
}

