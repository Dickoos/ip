using System;
using System.Windows.Forms;

namespace ip
{
    public partial class AddGuest : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        public AddGuest()
        {
            InitializeComponent();
        }

        private void ButtonAddGuestSave_Click(object sender, EventArgs e)
        {
            if (textBoxAddGuestFullName.Text == "")
            {
                MessageBox.Show("Имя не может быть пустым!", "Ошибка!", MessageBoxButtons.OK);

                return;
            }
            else if (textBoxAddGuestPhoneNum.Text == "")
            {
                MessageBox.Show("Номер телефона должен быть заполнен!");

                return;
            }
            else if (dBHelper.PhoneNumWasGuest(textBoxAddGuestPhoneNum.Text))
            {
                MessageBox.Show("Такой номер уже есть в базе данных!");

                return;
            }

            dBHelper.AddGuest(textBoxAddGuestFullName.Text, textBoxAddGuestPhoneNum.Text, textBoxAddGuestEmail.Text, textBoxAddGuestPersonalInformation.Text);

            textBoxAddGuestFullName.Text = "";
            textBoxAddGuestPhoneNum.Text = "";
            textBoxAddGuestEmail.Text = "";
            textBoxAddGuestPersonalInformation.Text = "";
        }
    }
}
