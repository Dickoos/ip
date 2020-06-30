using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip
{
    public partial class Pass : Form
    {
        int typeNewWindow;

        public Pass(int typeNewWindow)
        {
            InitializeComponent();

            this.typeNewWindow = typeNewWindow;
        }

        private void Button_tryPass_Click(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "23514317")
            {
                textBox_pass.Text = "";

                if (typeNewWindow == 1)
                {
                    var tempForm = new AllGuests();
                    tempForm.FormClosed += TempForm_FormClosed;
                    tempForm.Show();

                    this.Enabled = false;
                } else
                {
                    var tempForm = new MembersListMeet();
                    tempForm.FormClosed += TempForm_FormClosed;
                    tempForm.Show();

                    this.Enabled = false;
                }
            } else
            {
                textBox_pass.Text = "Неверный пароль";
            }
        }

        private void TempForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
