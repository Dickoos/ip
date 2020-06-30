using System;
using System.Windows.Forms;

namespace ip
{
    public partial class AddGuestOnMeet : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        public AddGuestOnMeet()
        {
            InitializeComponent();

            // Добавляем подсказки при наборе в textBox'е:
            var source = new AutoCompleteStringCollection();
            source.AddRange(dBHelper.GetAllGuestNamesAndPhones().ToArray());
            textBoxAddGuestOnMeetFullName.AutoCompleteCustomSource = source;
            textBoxAddGuestOnMeetFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxAddGuestOnMeetFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ButtonAddGuestOnMeet_Click(object sender, EventArgs e)
        {
            if (textBoxAddGuestOnMeetFullName.Text == "" || textBoxAddGuestOnMeetDate.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми!");

                return;
            }

            // Получаем id гостя
            var tempNameArr = textBoxAddGuestOnMeetFullName.Text.Split(' ');
            int id = Int32.Parse(tempNameArr[tempNameArr.Length - 1]);

            if (dBHelper.MeetWas(id, textBoxAddGuestOnMeetDate.Text))
            {
                MessageBox.Show("Такой пользователь на такую дату уже зарегестрирован!");

                return;
            }

            dBHelper.AddGuestOnMeet(id, textBoxAddGuestOnMeetDate.Text);

            textBoxAddGuestOnMeetFullName.Text = "";
            textBoxAddGuestOnMeetDate.Text = "";
        }
    }
}
