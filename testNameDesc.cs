using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testCreator
{
    public partial class testNameDesc : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;
                                                    Initial Catalog=dept_test_DB;
                                                    Integrated Security=True;");
        SqlDataAdapter myDA = new SqlDataAdapter();
        DataTable myDT = new DataTable();
        string deptName;
        string empEmail;
        
        
        
        public testNameDesc(string dept, string email)
        {
            InitializeComponent();
            deptName = dept;
            label3.Text = deptName;
            empEmail = email;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void testNameDesc_Load(object sender, EventArgs e)
        {
            myConn.Open();
            myDA = new SqlDataAdapter ("select test_name from test_elements", myConn);
            myDA.Fill(myDT);
            myConn.Close();
              
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (testNameText.Text == "")
            {
                MessageBox.Show("Please enter a name for the test");
                return;
            }   
            if (testDescText.Text.Length < 25)
            {
                MessageBox.Show("Please enter a longer description of test material");
                return;
            }
            if (reqForCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select the group required to take this test.");
                return;
            }
            foreach (DataRow thisRow in myDT.Rows)
            {
                if (thisRow["test_name"].ToString() == testNameText.Text)
                {
                    MessageBox.Show("A test with this name already exists, please use a different name");
                    return;
                }
            }
            createTest ct = new createTest(testNameText.Text,deptName, empEmail,reqForCombo.Text,passingScoreCbo.Text);
            ct.Show();
            this.Close();
                

        }
    }
}
