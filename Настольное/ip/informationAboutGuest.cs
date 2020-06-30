using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ip
{
    public partial class InformationAboutGuest : Form
    {
        readonly DBHelper dBHelper = new DBHelper();
        readonly int id;

        public InformationAboutGuest(int id)
        {
            InitializeComponent();

            List<string> tempInformationList = dBHelper.GetInformationAboutGuest(id);
            labelGuestId.Text = tempInformationList[0];
            textBoxFullName.Text = tempInformationList[1];
            textBoxPhoneNum.Text = tempInformationList[2];
            textBoxEmail.Text = tempInformationList[3];
            textBoxPersonalInformation.Text = tempInformationList[4];

            // Получаем id пользователя
            this.id = id;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "" || textBoxPhoneNum.Text == "")
            {
                MessageBox.Show("Поля 'ФИО' и 'Номер телефона должны быть заполнены!'");

                return;
            }

            dBHelper.UpdateGuestInformation(id, textBoxFullName.Text, textBoxPhoneNum.Text, textBoxEmail.Text, textBoxPersonalInformation.Text);
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            dBHelper.DelGuest(id);

            this.Close();
        }
    }
}
