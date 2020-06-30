using System;
using System.Windows.Forms;

namespace ip
{
    public partial class AddMemberOnMeet : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        public AddMemberOnMeet()
        {
            InitializeComponent();

            // Помощь при наборе имени
            var source = new AutoCompleteStringCollection();
            source.AddRange(dBHelper.GetAllMembersNamesAndPhones().ToArray());
            textBoxAddMemeberOnMeetFullName.AutoCompleteCustomSource = source;
            textBoxAddMemeberOnMeetFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxAddMemeberOnMeetFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ButtonAddMemberOnMeet_Click(object sender, EventArgs e)
        {
            if (textBoxAddMemeberOnMeetFullName.Text == "" || textBoxAddMemberOnMeetDate.Text == "" || textBoxPosition.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми!");

                return;
            }

            // Получаем id участника
            var tempNameArr = textBoxAddMemeberOnMeetFullName.Text.Split(' ');
            int id = Int32.Parse(tempNameArr[tempNameArr.Length - 1]);

            if (dBHelper.MeetWasMember(id, textBoxAddMemberOnMeetDate.Text))
            {
                MessageBox.Show("Такой пользователь на такую дату уже зарегестрирован!");

                return;
            }

            dBHelper.AddMemberOnMeet(id, textBoxPosition.Text, textBoxAddMemberOnMeetDate.Text);

            textBoxAddMemeberOnMeetFullName.Text = "";
            textBoxPosition.Text = "";
            textBoxAddMemberOnMeetDate.Text = "";
        }
    }
}
