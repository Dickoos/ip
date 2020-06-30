using System;
using System.Windows.Forms;

namespace ip
{
    public partial class AddMembers : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        public AddMembers()
        {
            InitializeComponent();
        }

        private void ButtonAddMemberSave_Click(object sender, EventArgs e)
        {
            if (textBoxAddMemberFullName.Text == "")
            {
                MessageBox.Show("Имя не может быть пустым!", "Ошибка!", MessageBoxButtons.OK);

                return;
            }
            else if (textBoxAddMemberPhoneNum.Text == "")
            {
                MessageBox.Show("Номер телефона должен быть заполнен!");

                return;
            }
            else if (dBHelper.PhoneNumWasMembers(textBoxAddMemberPhoneNum.Text))
            {
                MessageBox.Show("Такой номер уже есть в базе данных!");

                return;
            }

            dBHelper.AddMember(textBoxAddMemberFullName.Text, textBoxAddMemberPhoneNum.Text, textBoxAddMemberEmail.Text);

            textBoxAddMemberFullName.Text = "";
            textBoxAddMemberPhoneNum.Text = "";
            textBoxAddMemberEmail.Text = "";
        }
    }
}
