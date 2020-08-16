using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCreator
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void editTest_Click(object sender, EventArgs e)
        {
            if(deptCombo.SelectedItem == null || empEmail.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please select your department and fill in username and password");
            }
            editTestSelect et = new editTestSelect(deptCombo.Text);
            et.Show();
            this.Hide();
        }

        private void createTest_Click(object sender, EventArgs e)
        {
            if (deptCombo.SelectedItem == null || empEmail.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please select your department and fill in username and password");
                return;
            }
            createInstructions ci = new createInstructions(deptCombo.Text,empEmail.Text);
            ci.Show();
            this.Hide();
        }

        private void takeTest_Click(object sender, EventArgs e)
        {
            if (deptCombo.SelectedItem == null || empEmail.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please select your department and fill in username and password");
                return;
            }
            takeTest tt = new takeTest(Convert.ToString(deptCombo));
            tt.Show();
            this.Hide();
        }
    }
}
