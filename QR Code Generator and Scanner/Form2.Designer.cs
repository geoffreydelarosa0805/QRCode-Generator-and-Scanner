namespace QR_Code_Generator_and_Scanner
{
    partial class FormQRCode
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
            this.labelIdentification = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxIdentification = new System.Windows.Forms.TextBox();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.labelCamera = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdentification
            // 
            this.labelIdentification.AutoSize = true;
            this.labelIdentification.BackColor = System.Drawing.Color.Transparent;
            this.labelIdentification.ForeColor = System.Drawing.Color.White;
            this.labelIdentification.Location = new System.Drawing.Point(456, 35);
            this.labelIdentification.Name = "labelIdentification";
            this.labelIdentification.Size = new System.Drawing.Size(83, 15);
            this.labelIdentification.TabIndex = 13;
            this.labelIdentification.Text = "Identification :";
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(344, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(72, 23);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxIdentification
            // 
            this.textBoxIdentification.Location = new System.Drawing.Point(456, 72);
            this.textBoxIdentification.Multiline = true;
            this.textBoxIdentification.Name = "textBoxIdentification";
            this.textBoxIdentification.Size = new System.Drawing.Size(308, 348);
            this.textBoxIdentification.TabIndex = 11;
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(96, 31);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(223, 23);
            this.comboBoxDevice.TabIndex = 10;
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCamera.Location = new System.Drawing.Point(36, 72);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(404, 348);
            this.pictureBoxCamera.TabIndex = 9;
            this.pictureBoxCamera.TabStop = false;
            // 
            // labelCamera
            // 
            this.labelCamera.AutoSize = true;
            this.labelCamera.BackColor = System.Drawing.Color.Transparent;
            this.labelCamera.ForeColor = System.Drawing.Color.White;
            this.labelCamera.Location = new System.Drawing.Point(36, 34);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(54, 15);
            this.labelCamera.TabIndex = 8;
            this.labelCamera.Text = "Camera :";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIdentification);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxIdentification);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.pictureBoxCamera);
            this.Controls.Add(this.labelCamera);
            this.Name = "FormQRCode";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQRCode_FormClosing);
            this.Load += new System.EventHandler(this.FormQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelIdentification;
        private Button buttonStart;
        private TextBox textBoxIdentification;
        private ComboBox comboBoxDevice;
        private PictureBox pictureBoxCamera;
        private Label labelCamera;
        private System.Windows.Forms.Timer timer;
    }
}