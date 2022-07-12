namespace QR_Code_Generator_and_Scanner
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
            this.groupBoxQRCode = new System.Windows.Forms.GroupBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelGenerate = new System.Windows.Forms.Label();
            this.buttonScanner = new System.Windows.Forms.Button();
            this.labelContacts = new System.Windows.Forms.Label();
            this.labelScanner = new System.Windows.Forms.Label();
            this.buttonSeeker = new System.Windows.Forms.Button();
            this.dateTimePickerSeeker = new System.Windows.Forms.DateTimePicker();
            this.label_ContactsofUsers = new System.Windows.Forms.Label();
            this.dateTimePicker_DateofFilling = new System.Windows.Forms.DateTimePicker();
            this.label_DateofFilling = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxOtherPersontoContact = new System.Windows.Forms.GroupBox();
            this.textBox_EmailAddress = new System.Windows.Forms.TextBox();
            this.textBox_WorkplaceAddress = new System.Windows.Forms.TextBox();
            this.label_WorkplaceAddress = new System.Windows.Forms.Label();
            this.label_EmailAddress = new System.Windows.Forms.Label();
            this.label_Occupation = new System.Windows.Forms.Label();
            this.textBox_ContactNo = new System.Windows.Forms.TextBox();
            this.textBox_Relationship = new System.Windows.Forms.TextBox();
            this.label_ContactNo = new System.Windows.Forms.Label();
            this.label_PersonName = new System.Windows.Forms.Label();
            this.textBox_PersonAddress = new System.Windows.Forms.TextBox();
            this.label_PersonAddress = new System.Windows.Forms.Label();
            this.textBox_PersonName = new System.Windows.Forms.TextBox();
            this.label_Relationship = new System.Windows.Forms.Label();
            this.textBox_Occupation = new System.Windows.Forms.TextBox();
            this.labelContactTracingForm = new System.Windows.Forms.Label();
            this.groupBox_PersonalInformation = new System.Windows.Forms.GroupBox();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Telephone = new System.Windows.Forms.Label();
            this.label_PhoneNo = new System.Windows.Forms.Label();
            this.textBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Birthdate = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Telephone = new System.Windows.Forms.TextBox();
            this.label_Age = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.groupBoxOtherPersontoContact.SuspendLayout();
            this.groupBox_PersonalInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQRCode
            // 
            this.groupBoxQRCode.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQRCode.Controls.Add(this.picQRCode);
            this.groupBoxQRCode.Controls.Add(this.buttonSave);
            this.groupBoxQRCode.Controls.Add(this.labelGenerate);
            this.groupBoxQRCode.Location = new System.Drawing.Point(528, 396);
            this.groupBoxQRCode.Name = "groupBoxQRCode";
            this.groupBoxQRCode.Size = new System.Drawing.Size(308, 177);
            this.groupBoxQRCode.TabIndex = 67;
            this.groupBoxQRCode.TabStop = false;
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.Color.Transparent;
            this.picQRCode.Location = new System.Drawing.Point(146, 22);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(145, 145);
            this.picQRCode.TabIndex = 37;
            this.picQRCode.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.buttonSave.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSave.Location = new System.Drawing.Point(37, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelGenerate
            // 
            this.labelGenerate.AutoSize = true;
            this.labelGenerate.BackColor = System.Drawing.Color.Transparent;
            this.labelGenerate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGenerate.ForeColor = System.Drawing.Color.Black;
            this.labelGenerate.Location = new System.Drawing.Point(7, 24);
            this.labelGenerate.Name = "labelGenerate";
            this.labelGenerate.Size = new System.Drawing.Size(136, 105);
            this.labelGenerate.TabIndex = 36;
            this.labelGenerate.Text = "To save your\r\nQR Code,\r\nclick the Save\r\nbutton, then\r\nsave the file\r\nto PNG or JP" +
    "EG type\r\nand click Save.";
            this.labelGenerate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonScanner
            // 
            this.buttonScanner.BackColor = System.Drawing.Color.Transparent;
            this.buttonScanner.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.buttonScanner.ForeColor = System.Drawing.Color.Transparent;
            this.buttonScanner.Location = new System.Drawing.Point(763, 595);
            this.buttonScanner.Name = "buttonScanner";
            this.buttonScanner.Size = new System.Drawing.Size(75, 23);
            this.buttonScanner.TabIndex = 66;
            this.buttonScanner.Text = "Scanner";
            this.buttonScanner.UseVisualStyleBackColor = false;
            this.buttonScanner.Click += new System.EventHandler(this.buttonScanner_Click);
            // 
            // labelContacts
            // 
            this.labelContacts.AutoSize = true;
            this.labelContacts.BackColor = System.Drawing.Color.Transparent;
            this.labelContacts.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContacts.ForeColor = System.Drawing.Color.White;
            this.labelContacts.Location = new System.Drawing.Point(29, 552);
            this.labelContacts.Name = "labelContacts";
            this.labelContacts.Size = new System.Drawing.Size(306, 32);
            this.labelContacts.TabIndex = 65;
            this.labelContacts.Text = "          To know the people who filled out on a specific \r\ndate, insert the date" +
    " that you want to know.";
            // 
            // labelScanner
            // 
            this.labelScanner.AutoSize = true;
            this.labelScanner.BackColor = System.Drawing.Color.Transparent;
            this.labelScanner.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScanner.ForeColor = System.Drawing.Color.White;
            this.labelScanner.Location = new System.Drawing.Point(516, 599);
            this.labelScanner.Name = "labelScanner";
            this.labelScanner.Size = new System.Drawing.Size(247, 15);
            this.labelScanner.TabIndex = 64;
            this.labelScanner.Text = "Click the button to Scan your QR Code";
            // 
            // buttonSeeker
            // 
            this.buttonSeeker.BackColor = System.Drawing.Color.Transparent;
            this.buttonSeeker.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.buttonSeeker.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSeeker.Location = new System.Drawing.Point(249, 591);
            this.buttonSeeker.Name = "buttonSeeker";
            this.buttonSeeker.Size = new System.Drawing.Size(75, 23);
            this.buttonSeeker.TabIndex = 63;
            this.buttonSeeker.Text = "Seek";
            this.buttonSeeker.UseVisualStyleBackColor = false;
            this.buttonSeeker.Click += new System.EventHandler(this.buttonSeeker_Click);
            // 
            // dateTimePickerSeeker
            // 
            this.dateTimePickerSeeker.Location = new System.Drawing.Point(26, 591);
            this.dateTimePickerSeeker.Name = "dateTimePickerSeeker";
            this.dateTimePickerSeeker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerSeeker.TabIndex = 62;
            // 
            // label_ContactsofUsers
            // 
            this.label_ContactsofUsers.AutoSize = true;
            this.label_ContactsofUsers.BackColor = System.Drawing.Color.Transparent;
            this.label_ContactsofUsers.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ContactsofUsers.ForeColor = System.Drawing.Color.White;
            this.label_ContactsofUsers.Location = new System.Drawing.Point(26, 535);
            this.label_ContactsofUsers.Name = "label_ContactsofUsers";
            this.label_ContactsofUsers.Size = new System.Drawing.Size(157, 14);
            this.label_ContactsofUsers.TabIndex = 61;
            this.label_ContactsofUsers.Text = "Contacts of Users :";
            // 
            // dateTimePicker_DateofFilling
            // 
            this.dateTimePicker_DateofFilling.Location = new System.Drawing.Point(641, 60);
            this.dateTimePicker_DateofFilling.Name = "dateTimePicker_DateofFilling";
            this.dateTimePicker_DateofFilling.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_DateofFilling.TabIndex = 60;
            // 
            // label_DateofFilling
            // 
            this.label_DateofFilling.AutoSize = true;
            this.label_DateofFilling.BackColor = System.Drawing.Color.Transparent;
            this.label_DateofFilling.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_DateofFilling.ForeColor = System.Drawing.Color.White;
            this.label_DateofFilling.Location = new System.Drawing.Point(678, 37);
            this.label_DateofFilling.Name = "label_DateofFilling";
            this.label_DateofFilling.Size = new System.Drawing.Size(128, 14);
            this.label_DateofFilling.TabIndex = 57;
            this.label_DateofFilling.Text = "Date of Filling :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.buttonCancel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Location = new System.Drawing.Point(403, 402);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 59;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxOtherPersontoContact
            // 
            this.groupBoxOtherPersontoContact.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_EmailAddress);
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_WorkplaceAddress);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_WorkplaceAddress);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_EmailAddress);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_Occupation);
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_ContactNo);
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_Relationship);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_ContactNo);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_PersonName);
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_PersonAddress);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_PersonAddress);
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_PersonName);
            this.groupBoxOtherPersontoContact.Controls.Add(this.label_Relationship);
            this.groupBoxOtherPersontoContact.Controls.Add(this.textBox_Occupation);
            this.groupBoxOtherPersontoContact.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOtherPersontoContact.ForeColor = System.Drawing.Color.White;
            this.groupBoxOtherPersontoContact.Location = new System.Drawing.Point(403, 101);
            this.groupBoxOtherPersontoContact.Name = "groupBoxOtherPersontoContact";
            this.groupBoxOtherPersontoContact.Size = new System.Drawing.Size(417, 280);
            this.groupBoxOtherPersontoContact.TabIndex = 58;
            this.groupBoxOtherPersontoContact.TabStop = false;
            this.groupBoxOtherPersontoContact.Text = "Other Person to Contact";
            // 
            // textBox_EmailAddress
            // 
            this.textBox_EmailAddress.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_EmailAddress.Location = new System.Drawing.Point(204, 100);
            this.textBox_EmailAddress.Name = "textBox_EmailAddress";
            this.textBox_EmailAddress.Size = new System.Drawing.Size(192, 24);
            this.textBox_EmailAddress.TabIndex = 36;
            // 
            // textBox_WorkplaceAddress
            // 
            this.textBox_WorkplaceAddress.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_WorkplaceAddress.Location = new System.Drawing.Point(204, 240);
            this.textBox_WorkplaceAddress.Name = "textBox_WorkplaceAddress";
            this.textBox_WorkplaceAddress.Size = new System.Drawing.Size(192, 24);
            this.textBox_WorkplaceAddress.TabIndex = 33;
            // 
            // label_WorkplaceAddress
            // 
            this.label_WorkplaceAddress.AutoSize = true;
            this.label_WorkplaceAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_WorkplaceAddress.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_WorkplaceAddress.Location = new System.Drawing.Point(50, 247);
            this.label_WorkplaceAddress.Name = "label_WorkplaceAddress";
            this.label_WorkplaceAddress.Size = new System.Drawing.Size(151, 14);
            this.label_WorkplaceAddress.TabIndex = 26;
            this.label_WorkplaceAddress.Text = "Workplace Address :";
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.AutoSize = true;
            this.label_EmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_EmailAddress.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EmailAddress.Location = new System.Drawing.Point(50, 108);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(108, 14);
            this.label_EmailAddress.TabIndex = 35;
            this.label_EmailAddress.Text = "Email Address :";
            // 
            // label_Occupation
            // 
            this.label_Occupation.AutoSize = true;
            this.label_Occupation.BackColor = System.Drawing.Color.Transparent;
            this.label_Occupation.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Occupation.Location = new System.Drawing.Point(50, 213);
            this.label_Occupation.Name = "label_Occupation";
            this.label_Occupation.Size = new System.Drawing.Size(93, 14);
            this.label_Occupation.TabIndex = 24;
            this.label_Occupation.Text = "Occupation :";
            // 
            // textBox_ContactNo
            // 
            this.textBox_ContactNo.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ContactNo.Location = new System.Drawing.Point(204, 135);
            this.textBox_ContactNo.Name = "textBox_ContactNo";
            this.textBox_ContactNo.Size = new System.Drawing.Size(192, 24);
            this.textBox_ContactNo.TabIndex = 30;
            // 
            // textBox_Relationship
            // 
            this.textBox_Relationship.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Relationship.Location = new System.Drawing.Point(204, 65);
            this.textBox_Relationship.Name = "textBox_Relationship";
            this.textBox_Relationship.Size = new System.Drawing.Size(192, 24);
            this.textBox_Relationship.TabIndex = 28;
            // 
            // label_ContactNo
            // 
            this.label_ContactNo.AutoSize = true;
            this.label_ContactNo.BackColor = System.Drawing.Color.Transparent;
            this.label_ContactNo.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ContactNo.Location = new System.Drawing.Point(50, 142);
            this.label_ContactNo.Name = "label_ContactNo";
            this.label_ContactNo.Size = new System.Drawing.Size(97, 14);
            this.label_ContactNo.TabIndex = 23;
            this.label_ContactNo.Text = "Contact No. :";
            // 
            // label_PersonName
            // 
            this.label_PersonName.AutoSize = true;
            this.label_PersonName.BackColor = System.Drawing.Color.Transparent;
            this.label_PersonName.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PersonName.Location = new System.Drawing.Point(50, 34);
            this.label_PersonName.Name = "label_PersonName";
            this.label_PersonName.Size = new System.Drawing.Size(108, 14);
            this.label_PersonName.TabIndex = 19;
            this.label_PersonName.Text = "Person\'s Name :";
            // 
            // textBox_PersonAddress
            // 
            this.textBox_PersonAddress.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PersonAddress.Location = new System.Drawing.Point(204, 170);
            this.textBox_PersonAddress.Name = "textBox_PersonAddress";
            this.textBox_PersonAddress.Size = new System.Drawing.Size(192, 24);
            this.textBox_PersonAddress.TabIndex = 29;
            // 
            // label_PersonAddress
            // 
            this.label_PersonAddress.AutoSize = true;
            this.label_PersonAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_PersonAddress.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PersonAddress.Location = new System.Drawing.Point(50, 178);
            this.label_PersonAddress.Name = "label_PersonAddress";
            this.label_PersonAddress.Size = new System.Drawing.Size(129, 14);
            this.label_PersonAddress.TabIndex = 22;
            this.label_PersonAddress.Text = "Person\'s Address :";
            // 
            // textBox_PersonName
            // 
            this.textBox_PersonName.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PersonName.Location = new System.Drawing.Point(204, 30);
            this.textBox_PersonName.Name = "textBox_PersonName";
            this.textBox_PersonName.Size = new System.Drawing.Size(192, 24);
            this.textBox_PersonName.TabIndex = 20;
            // 
            // label_Relationship
            // 
            this.label_Relationship.AutoSize = true;
            this.label_Relationship.BackColor = System.Drawing.Color.Transparent;
            this.label_Relationship.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Relationship.Location = new System.Drawing.Point(50, 73);
            this.label_Relationship.Name = "label_Relationship";
            this.label_Relationship.Size = new System.Drawing.Size(98, 14);
            this.label_Relationship.TabIndex = 21;
            this.label_Relationship.Text = "Relationship :";
            // 
            // textBox_Occupation
            // 
            this.textBox_Occupation.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Occupation.Location = new System.Drawing.Point(204, 205);
            this.textBox_Occupation.Name = "textBox_Occupation";
            this.textBox_Occupation.Size = new System.Drawing.Size(192, 24);
            this.textBox_Occupation.TabIndex = 31;
            // 
            // labelContactTracingForm
            // 
            this.labelContactTracingForm.AutoSize = true;
            this.labelContactTracingForm.BackColor = System.Drawing.Color.Transparent;
            this.labelContactTracingForm.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContactTracingForm.ForeColor = System.Drawing.Color.White;
            this.labelContactTracingForm.Location = new System.Drawing.Point(285, 16);
            this.labelContactTracingForm.Name = "labelContactTracingForm";
            this.labelContactTracingForm.Size = new System.Drawing.Size(276, 31);
            this.labelContactTracingForm.TabIndex = 56;
            this.labelContactTracingForm.Text = "Contact Tracing Form";
            this.labelContactTracingForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_PersonalInformation
            // 
            this.groupBox_PersonalInformation.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Gender);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Email);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Email);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Gender);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Telephone);
            this.groupBox_PersonalInformation.Controls.Add(this.label_PhoneNo);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_PhoneNo);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Address);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Birthdate);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Surname);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Birthdate);
            this.groupBox_PersonalInformation.Controls.Add(this.label_FirstName);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Age);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Telephone);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Age);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_FirstName);
            this.groupBox_PersonalInformation.Controls.Add(this.label_Surname);
            this.groupBox_PersonalInformation.Controls.Add(this.textBox_Address);
            this.groupBox_PersonalInformation.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_PersonalInformation.ForeColor = System.Drawing.Color.White;
            this.groupBox_PersonalInformation.Location = new System.Drawing.Point(26, 101);
            this.groupBox_PersonalInformation.Name = "groupBox_PersonalInformation";
            this.groupBox_PersonalInformation.Size = new System.Drawing.Size(357, 366);
            this.groupBox_PersonalInformation.TabIndex = 55;
            this.groupBox_PersonalInformation.TabStop = false;
            this.groupBox_PersonalInformation.Text = "Personal Information";
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Gender.Location = new System.Drawing.Point(143, 101);
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(192, 24);
            this.textBox_Gender.TabIndex = 18;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Email.Location = new System.Drawing.Point(143, 241);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(192, 24);
            this.textBox_Email.TabIndex = 15;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Email.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Email.Location = new System.Drawing.Point(42, 248);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(48, 14);
            this.label_Email.TabIndex = 8;
            this.label_Email.Text = "Email :";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.BackColor = System.Drawing.Color.Transparent;
            this.label_Gender.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Gender.Location = new System.Drawing.Point(42, 109);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(65, 14);
            this.label_Gender.TabIndex = 17;
            this.label_Gender.Text = "Gender :";
            // 
            // label_Telephone
            // 
            this.label_Telephone.AutoSize = true;
            this.label_Telephone.BackColor = System.Drawing.Color.Transparent;
            this.label_Telephone.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Telephone.Location = new System.Drawing.Point(42, 319);
            this.label_Telephone.Name = "label_Telephone";
            this.label_Telephone.Size = new System.Drawing.Size(82, 14);
            this.label_Telephone.TabIndex = 7;
            this.label_Telephone.Text = "Telephone :";
            // 
            // label_PhoneNo
            // 
            this.label_PhoneNo.AutoSize = true;
            this.label_PhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.label_PhoneNo.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_PhoneNo.Location = new System.Drawing.Point(42, 283);
            this.label_PhoneNo.Name = "label_PhoneNo";
            this.label_PhoneNo.Size = new System.Drawing.Size(79, 14);
            this.label_PhoneNo.TabIndex = 9;
            this.label_PhoneNo.Text = "Phone No. :";
            // 
            // textBox_PhoneNo
            // 
            this.textBox_PhoneNo.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PhoneNo.Location = new System.Drawing.Point(143, 276);
            this.textBox_PhoneNo.Name = "textBox_PhoneNo";
            this.textBox_PhoneNo.Size = new System.Drawing.Size(192, 24);
            this.textBox_PhoneNo.TabIndex = 16;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.BackColor = System.Drawing.Color.Transparent;
            this.label_Address.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Address.Location = new System.Drawing.Point(42, 214);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(69, 14);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address :";
            // 
            // textBox_Birthdate
            // 
            this.textBox_Birthdate.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Birthdate.Location = new System.Drawing.Point(143, 136);
            this.textBox_Birthdate.Name = "textBox_Birthdate";
            this.textBox_Birthdate.Size = new System.Drawing.Size(192, 24);
            this.textBox_Birthdate.TabIndex = 12;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Surname.Location = new System.Drawing.Point(143, 66);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(192, 24);
            this.textBox_Surname.TabIndex = 10;
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.BackColor = System.Drawing.Color.Transparent;
            this.label_Birthdate.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Birthdate.Location = new System.Drawing.Point(42, 143);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(80, 14);
            this.label_Birthdate.TabIndex = 5;
            this.label_Birthdate.Text = "Birthdate :";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.label_FirstName.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FirstName.Location = new System.Drawing.Point(42, 35);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(83, 14);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name :";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Age.Location = new System.Drawing.Point(143, 171);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(192, 24);
            this.textBox_Age.TabIndex = 11;
            // 
            // textBox_Telephone
            // 
            this.textBox_Telephone.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Telephone.Location = new System.Drawing.Point(143, 311);
            this.textBox_Telephone.Name = "textBox_Telephone";
            this.textBox_Telephone.Size = new System.Drawing.Size(192, 24);
            this.textBox_Telephone.TabIndex = 14;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.BackColor = System.Drawing.Color.Transparent;
            this.label_Age.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Age.Location = new System.Drawing.Point(42, 179);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(36, 14);
            this.label_Age.TabIndex = 4;
            this.label_Age.Text = "Age :";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_FirstName.Location = new System.Drawing.Point(143, 31);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(192, 24);
            this.textBox_FirstName.TabIndex = 2;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.BackColor = System.Drawing.Color.Transparent;
            this.label_Surname.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Surname.Location = new System.Drawing.Point(42, 74);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(73, 14);
            this.label_Surname.TabIndex = 3;
            this.label_Surname.Text = "Surname :";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Address.Location = new System.Drawing.Point(143, 206);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(192, 24);
            this.textBox_Address.TabIndex = 13;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.buttonSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.Location = new System.Drawing.Point(403, 444);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 54;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QR_Code_Generator_and_Scanner.Properties.Resources.contact_tracing_twitter;
            this.ClientSize = new System.Drawing.Size(866, 635);
            this.Controls.Add(this.groupBoxQRCode);
            this.Controls.Add(this.buttonScanner);
            this.Controls.Add(this.labelContacts);
            this.Controls.Add(this.labelScanner);
            this.Controls.Add(this.buttonSeeker);
            this.Controls.Add(this.dateTimePickerSeeker);
            this.Controls.Add(this.label_ContactsofUsers);
            this.Controls.Add(this.dateTimePicker_DateofFilling);
            this.Controls.Add(this.label_DateofFilling);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxOtherPersontoContact);
            this.Controls.Add(this.labelContactTracingForm);
            this.Controls.Add(this.groupBox_PersonalInformation);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxQRCode.ResumeLayout(false);
            this.groupBoxQRCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.groupBoxOtherPersontoContact.ResumeLayout(false);
            this.groupBoxOtherPersontoContact.PerformLayout();
            this.groupBox_PersonalInformation.ResumeLayout(false);
            this.groupBox_PersonalInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxQRCode;
        private PictureBox picQRCode;
        private Button buttonSave;
        private Label labelGenerate;
        private Button buttonScanner;
        private Label labelContacts;
        private Label labelScanner;
        private Button buttonSeeker;
        private DateTimePicker dateTimePickerSeeker;
        private Label label_ContactsofUsers;
        private DateTimePicker dateTimePicker_DateofFilling;
        private Label label_DateofFilling;
        private Button buttonCancel;
        private GroupBox groupBoxOtherPersontoContact;
        private TextBox textBox_EmailAddress;
        private TextBox textBox_WorkplaceAddress;
        private Label label_WorkplaceAddress;
        private Label label_EmailAddress;
        private Label label_Occupation;
        private TextBox textBox_ContactNo;
        private TextBox textBox_Relationship;
        private Label label_ContactNo;
        private Label label_PersonName;
        private TextBox textBox_PersonAddress;
        private Label label_PersonAddress;
        private TextBox textBox_PersonName;
        private Label label_Relationship;
        private TextBox textBox_Occupation;
        private Label labelContactTracingForm;
        private GroupBox groupBox_PersonalInformation;
        private TextBox textBox_Gender;
        private TextBox textBox_Email;
        private Label label_Email;
        private Label label_Gender;
        private Label label_Telephone;
        private Label label_PhoneNo;
        private TextBox textBox_PhoneNo;
        private Label label_Address;
        private TextBox textBox_Birthdate;
        private TextBox textBox_Surname;
        private Label label_Birthdate;
        private Label label_FirstName;
        private TextBox textBox_Age;
        private TextBox textBox_Telephone;
        private Label label_Age;
        private TextBox textBox_FirstName;
        private Label label_Surname;
        private TextBox textBox_Address;
        private Button buttonSubmit;
    }
}