namespace SerialCommander
{
    partial class MainForm
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
            this.PowerLabel = new System.Windows.Forms.Label();
            this.PowerTrackBar = new System.Windows.Forms.TrackBar();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ControllerComboBox = new System.Windows.Forms.ComboBox();
            this.ControllerLabel = new System.Windows.Forms.Label();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.SerialPortLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PlayerComboBox = new System.Windows.Forms.ComboBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(27, 107);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(37, 13);
            this.PowerLabel.TabIndex = 6;
            this.PowerLabel.Text = "Power";
            // 
            // PowerTrackBar
            // 
            this.PowerTrackBar.Enabled = false;
            this.PowerTrackBar.LargeChange = 10;
            this.PowerTrackBar.Location = new System.Drawing.Point(68, 107);
            this.PowerTrackBar.Maximum = 100;
            this.PowerTrackBar.Minimum = 60;
            this.PowerTrackBar.Name = "PowerTrackBar";
            this.PowerTrackBar.Size = new System.Drawing.Size(185, 45);
            this.PowerTrackBar.SmallChange = 5;
            this.PowerTrackBar.TabIndex = 5;
            this.PowerTrackBar.TickFrequency = 2;
            this.PowerTrackBar.Value = 100;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(178, 161);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ControllerComboBox
            // 
            this.ControllerComboBox.DisplayMember = "Name";
            this.ControllerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControllerComboBox.FormattingEnabled = true;
            this.ControllerComboBox.Location = new System.Drawing.Point(69, 80);
            this.ControllerComboBox.Name = "ControllerComboBox";
            this.ControllerComboBox.Size = new System.Drawing.Size(184, 21);
            this.ControllerComboBox.TabIndex = 3;
            this.ControllerComboBox.SelectedIndexChanged += new System.EventHandler(this.ControllerComboBox_SelectedIndexChanged);
            // 
            // ControllerLabel
            // 
            this.ControllerLabel.AutoSize = true;
            this.ControllerLabel.Location = new System.Drawing.Point(12, 83);
            this.ControllerLabel.Name = "ControllerLabel";
            this.ControllerLabel.Size = new System.Drawing.Size(51, 13);
            this.ControllerLabel.TabIndex = 2;
            this.ControllerLabel.Text = "Controller";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.DisplayMember = "PortName";
            this.SerialPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(69, 52);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(184, 21);
            this.SerialPortComboBox.TabIndex = 1;
            this.SerialPortComboBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortComboBox_SelectedIndexChanged);
            // 
            // SerialPortLabel
            // 
            this.SerialPortLabel.AutoSize = true;
            this.SerialPortLabel.Location = new System.Drawing.Point(12, 55);
            this.SerialPortLabel.Name = "SerialPortLabel";
            this.SerialPortLabel.Size = new System.Drawing.Size(55, 13);
            this.SerialPortLabel.TabIndex = 0;
            this.SerialPortLabel.Text = "Serial Port";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(299, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(27, 28);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(36, 13);
            this.PlayerLabel.TabIndex = 7;
            this.PlayerLabel.Text = "Player";
            // 
            // PlayerComboBox
            // 
            this.PlayerComboBox.DisplayMember = "Name";
            this.PlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerComboBox.FormattingEnabled = true;
            this.PlayerComboBox.Location = new System.Drawing.Point(68, 25);
            this.PlayerComboBox.Name = "PlayerComboBox";
            this.PlayerComboBox.Size = new System.Drawing.Size(185, 21);
            this.PlayerComboBox.TabIndex = 8;
            this.PlayerComboBox.SelectedIndexChanged += new System.EventHandler(this.PlayerComboBox_SelectedIndexChanged);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(68, 161);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 9;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.PlayerComboBox);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PowerTrackBar);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SerialPortLabel);
            this.Controls.Add(this.ControllerComboBox);
            this.Controls.Add(this.SerialPortComboBox);
            this.Controls.Add(this.ControllerLabel);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Serial Commander";
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrackBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ControllerComboBox;
        private System.Windows.Forms.Label ControllerLabel;
        private System.Windows.Forms.ComboBox SerialPortComboBox;
        private System.Windows.Forms.Label SerialPortLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.TrackBar PowerTrackBar;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.ComboBox PlayerComboBox;
        private System.Windows.Forms.Button AddPlayerButton;
    }
}

