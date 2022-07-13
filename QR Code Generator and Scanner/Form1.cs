using QRCoder;

namespace QR_Code_Generator_and_Scanner
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\HP\Documents\Outputs\Contact Tracing File\Contacts\" + dateTimePicker_DateofFilling.Text + ".txt", true);

            file.WriteLine("Date of Filling : " + dateTimePicker_DateofFilling.Text);
            file.WriteLine("First Name : " + textBox_FirstName.Text);
            file.WriteLine("Surname : " + textBox_Surname.Text);
            file.WriteLine("Gender : " + textBox_Gender.Text);
            file.WriteLine("Birthdate : " + textBox_Birthdate.Text);
            file.WriteLine("Age : " + textBox_Age.Text);
            file.WriteLine("Address : " + textBox_Address.Text);
            file.WriteLine("Email : " + textBox_Email.Text);
            file.WriteLine("Phone No. : " + textBox_PhoneNo.Text);
            file.WriteLine("Telephone : " + textBox_Telephone.Text);
            file.WriteLine("");
            file.WriteLine("Other Person to Contact");
            file.WriteLine("Person's Name : " + textBox_PersonName.Text);
            file.WriteLine("Relationship : " + textBox_Relationship.Text);
            file.WriteLine("Email Address : " + textBox_EmailAddress.Text);
            file.WriteLine("Contact No. : " + textBox_ContactNo.Text);
            file.WriteLine("Person's Address : " + textBox_PersonAddress.Text);
            file.WriteLine("Occupation : " + textBox_Occupation.Text);
            file.WriteLine("Workplace Address : " + textBox_WorkplaceAddress.Text);
            file.WriteLine("");
            file.WriteLine("*******************************************************");
            file.WriteLine("");

            file.Close();

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(("Date of Filling : " + dateTimePicker_DateofFilling.Text) + ("First Name : " + textBox_FirstName.Text) + ("Surname : " + textBox_Surname.Text) + ("Gender : " + textBox_Gender.Text)
             + ("Birthdate : " + textBox_Birthdate.Text) + ("Age : " + textBox_Age.Text) + ("Address : " + textBox_Address.Text) + ("Email : " + textBox_Email.Text) + ("Phone No. : " + textBox_PhoneNo.Text)
             + ("Telephone : " + textBox_Telephone.Text) + ("Person's Name : " + textBox_PersonName.Text) + ("Relationship : " + textBox_Relationship.Text) + ("Email Address : " + textBox_EmailAddress.Text)
             + ("Contact No. : " + textBox_ContactNo.Text) + ("Person's Address : " + textBox_PersonAddress.Text) + ("Occupation : " + textBox_Occupation.Text) + ("Workplace Address : " + textBox_WorkplaceAddress.Text), QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQRCode.Image = code.GetGraphic(5);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSeeker_Click(object sender, EventArgs e)
        {
            var Datafiles = Directory.GetFiles(@"C:\Users\HP\Documents\Outputs\Contact Tracing File\Contacts\");
            string date = dateTimePickerSeeker.Text;

            foreach (string data in Datafiles)
            {
                string dateTimePickerSeeker = File.ReadAllText(data);
                if (dateTimePickerSeeker.Contains(date))
                {
                    date = dateTimePickerSeeker;
                    MessageBox.Show(dateTimePickerSeeker.ToString());
                }
            }
        }

        private void buttonScanner_Click(object sender, EventArgs e)
        {
            FormQRCode form = new FormQRCode();
            form.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string initialDIR = @"C:\Users\HP\Documents\Outputs\Contact Tracing File\QR Codes";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picQRCode.Image.Save(dialog.FileName);
                MessageBox.Show(picQRCode.Text);
            }
        }
    }
}