using System;
using System.Windows.Forms;

namespace ip
{
    public partial class MembersListMeet : Form
    {
        readonly DBHelper dBHelper = new DBHelper();

        int lastBut = 0;

        public MembersListMeet()
        {
            InitializeComponent();

            var source = new AutoCompleteStringCollection();
            source.AddRange(dBHelper.GetAllMemberNames().ToArray());
            textBoxFullName.AutoCompleteCustomSource = source;
            textBoxFullName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            ButtonUpdateMembersList_Click(null, null);
        }

        private void TempForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;

            if (lastBut == 0)
                this.ButtonUpdateMembersList_Click(null, null);
            else
                this.ButtonSearch_Click(null, null);
        }

        private void ButtonUpdateMembersList_Click(object sender, EventArgs e)
        {
            listBoxAllMembersOnMeet.Items.Clear();

            var listAllMembersOnMeet = dBHelper.GetMembersOnMeet("", "");

            listBoxAllMembersOnMeet.BeginUpdate();
            foreach (string member in listAllMembersOnMeet)
                listBoxAllMembersOnMeet.Items.Add(member);
            listBoxAllMembersOnMeet.EndUpdate();

            lastBut = 0;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            listBoxAllMembersOnMeet.Items.Clear();

            var listMembersOnMeet = dBHelper.GetMembersOnMeet(textBoxFullName.Text, textBoxDate.Text);

            listBoxAllMembersOnMeet.BeginUpdate();
            foreach (string member in listMembersOnMeet)
                listBoxAllMembersOnMeet.Items.Add(member);
            listBoxAllMembersOnMeet.EndUpdate();

            lastBut = 1;
        }

        private void ButtonAddMembers_Click(object sender, EventArgs e)
        {
            var tempForm = new AddMembers();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;
        }

        private void ListBoxAllMembersOnMeet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxAllMembersOnMeet.SelectedItem != null)
            {
                var tempArr = listBoxAllMembersOnMeet.SelectedItem.ToString().Split(' ');

                if (tempArr[tempArr.Length - 2] == "(Не")
                    dBHelper.SetWasOrNotMembers(tempArr[tempArr.Length - 3], tempArr[tempArr.Length - 5], "0");
                else
                    dBHelper.SetWasOrNotMembers(tempArr[tempArr.Length - 2], tempArr[tempArr.Length - 4], "1");

                if (lastBut == 0)
                    this.ButtonUpdateMembersList_Click(null, null);
                else
                    this.ButtonSearch_Click(null, null);
            }
        }

        private void ButtonAddMemberToMeet_Click(object sender, EventArgs e)
        {
            var tempForm = new AddMemberOnMeet();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;
        }

        private void ButtonTableAllMembers_Click(object sender, EventArgs e)
        {
            var tempForm = new AllMembers();
            tempForm.FormClosed += TempForm_FormClosed;
            tempForm.Show();

            this.Enabled = false;
        }
    }
}
