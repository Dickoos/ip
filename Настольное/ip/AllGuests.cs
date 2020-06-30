using System;
using System.Windows.Forms;

namespace ip
{
    public partial class AllGuests : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        public AllGuests()
        {
            InitializeComponent();

            // Делаем помощь при наборе имени
            var source = new AutoCompleteStringCollection();
            source.AddRange(dBHelper.GetAllGuestNames().ToArray());
            textBoxAllGuestsFullName.AutoCompleteCustomSource = source;
            textBoxAllGuestsFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxAllGuestsFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Сразу обновляем список гостей
            ButtonUpdate_Click(null, null);
        }

        private void ButtonAllGuestsSearch_Click(object sender, EventArgs e)
        {
            listBoxAllGuestsList.Items.Clear();

            var listAllGuestsList = dBHelper.GetGuests(textBoxAllGuestsFullName.Text);

            // Обновляем список гостей
            listBoxAllGuestsList.BeginUpdate();
            foreach (string guest in listAllGuestsList)
                listBoxAllGuestsList.Items.Add(guest);
            listBoxAllGuestsList.EndUpdate();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            listBoxAllGuestsList.Items.Clear();

            var listAllGuestsList = dBHelper.GetGuests("");

            // Обновляем список гостей
            listBoxAllGuestsList.BeginUpdate();
            foreach (string guest in listAllGuestsList)
                listBoxAllGuestsList.Items.Add(guest);
            listBoxAllGuestsList.EndUpdate();
        }

        private void ListBoxAllGuestsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxAllGuestsList.SelectedItem != null) // Если что-то выбрано из списка
            {
                var tempArr = listBoxAllGuestsList.SelectedItem.ToString().Split(' ');

                var tempForm = new InformationAboutGuest(int.Parse(tempArr[tempArr.Length - 1])); // Извлекаем из элемента списка id, и по нему находим информацию
                tempForm.FormClosed += TempForm_FormClosed;
                tempForm.Show();
            }
        }

        // Обновление по закрытию доп. окон
        private void TempForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ButtonUpdate_Click(null, null);
        }
    }
}
