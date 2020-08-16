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
    public partial class createInstructions : Form
    {
        string deptName;
        string empEmail;
        public createInstructions(string dept, string email)
        {
            InitializeComponent();
            deptName = dept;
            empEmail = email;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu();
            mm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            testNameDesc testDesc = new testNameDesc(deptName, empEmail);
            testDesc.Show();
            this.Close();
        }
    }
}
