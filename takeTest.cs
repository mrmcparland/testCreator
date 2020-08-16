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
    public partial class takeTest : Form
    {
        string empDept;
        string testName;
        SqlConnection myConn = new SqlConnection();
        SqlDataAdapter myDA = new SqlDataAdapter();
        DataTable myDT = new DataTable();

        List<string> testNameList = new List<string>();

        


        public takeTest(string dept)
        {
            InitializeComponent();
            empDept = dept;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboTestName.SelectedItem == null)
            {
                MessageBox.Show("Please select your test.");
                return;
            }
            testName = Convert.ToString(Convert.ToString(cboTestName.SelectedItem));
            testForm tf = new testForm(empDept, testName);
            tf.Show();
            this.Close();
        }

        private void takeTest_Load(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;
                                                   Initial Catalog=dept_test_DB;
                                                    Integrated Security=True;");
            SqlDataAdapter myDA = new SqlDataAdapter("select test_name from test_names", myConn);

            myDA.Fill(myDT);
            //datatable to list
            foreach(DataRow myRow in myDT.Rows)
            {
                testNameList.Add(myRow["test_name"].ToString());
            }
            //list to combo box
            for(int i = 0; i<myDT.Rows.Count; i++)
            {
                cboTestName.DataSource = testNameList;
            }
            cboTestName.SelectedIndex = -1;
        }
    }
}
