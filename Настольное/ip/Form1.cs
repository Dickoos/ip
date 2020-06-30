using System;
using System.Windows.Forms;

namespace ip
{
    public partial class Form1 : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        // Переменная последней нажатой кнопки
        int lastBut = 0;

        public Form1()
        {
            InitializeComponent();

            // Вносим требуемую информацию о пк
            dBHelper.CheckUserNameAndUserDomainName(SystemInformation.UserName, SystemInformation.UserDomainName);

            // Помощник набора
            var source = new AutoCompleteStringCollection();
            source.AddRange(dBHelper.GetAllGuestNames().ToArray());
            textBoxFullName.AutoCompleteCustomSource = source;
            textBoxFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Обновление списка гостей
            this.ButtonUpdateGuestList_Click(null, null);
        }

        private void ButtonAddGuest_Click(object sender, EventArgs e)
        {
            var tempForm = new AddGuest();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;
        }

        private void TempForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;

            // Отображаем актуальный список
            if (lastBut == 0)
                this.ButtonUpdateGuestList_Click(null, null);
            else
                this.ButtonSearch_Click(null, null);
        }

        private void ButtonAddGuestToMeet_Click(object sender, EventArgs e)
        {
            var tempForm = new AddGuestOnMeet();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;
        }

        private void ButtonTableAllGuests_Click(object sender, EventArgs e)
        {
            var tempForm = new Pass(1);
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;

            /*var tempForm = new AllGuests();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;*/
        }

        private void ButtonAllMembersTable_Click(object sender, EventArgs e)
        {
            var tempForm = new Pass(2);
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;

            /*var tempForm = new MembersListMeet();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;*/
        }

        private void ButtonUpdateGuestList_Click(object sender, EventArgs e)
        {
            listBoxAllGuestsOnMeet.Items.Clear();

            var listAllGuestsOnMeet = dBHelper.GetGuestsOnMeet("", "");

            listBoxAllGuestsOnMeet.BeginUpdate();
            foreach (string guest in listAllGuestsOnMeet)
                listBoxAllGuestsOnMeet.Items.Add(guest);
            listBoxAllGuestsOnMeet.EndUpdate();

            lastBut = 0; // Номер кнопки обновления
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            listBoxAllGuestsOnMeet.Items.Clear();

            var listGuestsOnMeet = dBHelper.GetGuestsOnMeet(textBoxFullName.Text, textBoxDate.Text);

            listBoxAllGuestsOnMeet.BeginUpdate();
            foreach (string guest in listGuestsOnMeet)
                listBoxAllGuestsOnMeet.Items.Add(guest);
            listBoxAllGuestsOnMeet.EndUpdate();

            lastBut = 1; // Номер кнопки поиска
        }

        private void ListBoxAllGuestsOnMeet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxAllGuestsOnMeet.SelectedItem != null) // Если что-то выбрано
            {
                var tempArr = listBoxAllGuestsOnMeet.SelectedItem.ToString().Split(' ');

                // Проверка был/не был и изменение на обратное
                if (tempArr[tempArr.Length - 2] == "(Не")
                    dBHelper.SetWasOrNotGuests(tempArr[tempArr.Length - 3], tempArr[tempArr.Length - 5], "0");
                else
                    dBHelper.SetWasOrNotGuests(tempArr[tempArr.Length - 2], tempArr[tempArr.Length - 4], "1");

                if (lastBut == 0)
                    this.ButtonUpdateGuestList_Click(null, null);
                else
                    this.ButtonSearch_Click(null, null);
            }
        }
    }
}
