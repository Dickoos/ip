using System;
using System.Windows.Forms;

namespace ip
{
    public partial class AllMembers : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        public AllMembers()
        {
            InitializeComponent();

            // Помощь при наборе текста
            var source = new AutoCompleteStringCollection();
            source.AddRange(dBHelper.GetAllMemberNames().ToArray());
            textBoxAllMemeberFullName.AutoCompleteCustomSource = source;
            textBoxAllMemeberFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxAllMemeberFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Обновляем список участников
            ButtonUpdate_Click(null, null);
        }

        private void ButtonAllMemeberSearch_Click(object sender, EventArgs e)
        {
            listBoxAllMemeberList.Items.Clear();

            var listAllMemberList = dBHelper.GetMembers(textBoxAllMemeberFullName.Text);

            listBoxAllMemeberList.BeginUpdate();
            foreach (string member in listAllMemberList)
                listBoxAllMemeberList.Items.Add(member);
            listBoxAllMemeberList.EndUpdate();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            listBoxAllMemeberList.Items.Clear();

            var listAllMemberList = dBHelper.GetMembers("");

            listBoxAllMemeberList.BeginUpdate();
            foreach (string memebr in listAllMemberList)
                listBoxAllMemeberList.Items.Add(memebr);
            listBoxAllMemeberList.EndUpdate();
        }

        private void TempForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ButtonUpdate_Click(null, null);
        }

        private void ListBoxAllMemeberList_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxAllMemeberList.SelectedItem != null)
            {
                var tempArr = listBoxAllMemeberList.SelectedItem.ToString().Split(' ');

                var tempForm = new InformationAboutMember(int.Parse(tempArr[tempArr.Length - 1]));
                tempForm.FormClosed += TempForm_FormClosed;
                tempForm.Show();
            }
        }
    }
}
